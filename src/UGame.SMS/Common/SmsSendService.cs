using AiUo;
using AiUo.Data.SqlSugar;
using AiUo.Logging;
using AiUo.Text;
using UGame.SMS.DAL;

namespace UGame.SMS.Common
{
    internal class SmsSendService
    {
        public async Task<XxyySmsDto> SendAsync(XxyySmsIpo ipo)
        {
            var ret = new XxyySmsDto();
            var orderEo = new Sms_sms_orderPO();
            var ipoJson = SerializerUtil.SerializeJsonNet(ipo);
            try
            {
                await SetOrderEo(ipo, orderEo);

                AiUoUtil.ThrowIfNull("XxyySmsUtil.SendAsync时，Mobile不能为空", ipo.Mobile);
                AiUoUtil.ThrowIfFunc(() => ipo.TemplateId < 0, "XxyySmsUtil.SendAsync时，TemplateId必须设置值");
                if (string.IsNullOrEmpty(ipo.SmsId) && string.IsNullOrEmpty(ipo.OperatorId))
                    throw new Exception("XxyySmsUtil.SendAsync时，OperatorId和ipo.SmsId不能同时为空");

                ret.Content = orderEo.Content = GetContent(ipo, orderEo);
                var smsIds = SelectSmsIds(ipo);
                foreach (var smsId in smsIds)
                {
                    ret.SmsId = orderEo.SmsID = smsId;
                    ret.OtherSmsIds = smsIds;

                    var proxy = XxyySmsUtil.CreateProxy(smsId);
                    orderEo.SmsBaseID = proxy.SmsEo.SmsBaseID;
                    var proxyDto = await proxy.SendAsync(ipo.Mobile, ret.Content);
                    orderEo.ResponseTime = DateTime.UtcNow;
                    orderEo.ResponseBody = SerializerUtil.SerializeJsonNet(proxyDto);
                    ret.SmsCode = orderEo.SmsCode = proxyDto.SmsCode;
                    ret.SmsOrderId = orderEo.SmsOrderId = proxyDto.SmsOrderId;
                    ret.SmsResponse = proxyDto.SmsResponse;
                    ret.Success = proxyDto.Success;
                    //0-初始1-处理中2-成功3-失败4-已回滚5-异常且需处理6-异常已处理
                    orderEo.Status = ret.Success ? 2 : 3;
                    await DbUtil.GetRepository<Sms_sms_orderPO>().InsertAsync(orderEo);

                    //成功则退出
                    if (ret.Success || !ipo.IsRetrySend)
                        break;
                    orderEo.OrderID = ObjectId.NewId();
                }
            }
            catch (Exception ex)
            {
                ret.Success = false;
                ret.Exception = ex;
                if (ExceptionUtil.TryGetCustomException(ex, out var exc))
                {
                    ret.Code = exc.Code;
                    ret.Message = exc.Message;
                }
                else
                {
                    ret.Message = ex.Message;
                }
                orderEo.Status = 3;
                orderEo.Exception += SerializerUtil.SerializeJsonNet(ex);
                LogUtil.Error(ex, $"SmsSendService.SendAsync异常。ipo:{ipoJson}");
            }
            return ret;
        }
        private List<string> SelectSmsIds(XxyySmsIpo ipo)
        {
            if (!string.IsNullOrEmpty(ipo.SmsId))
                return new List<string> { ipo.SmsId };

            var list = MemCacheUtil.GetTemplateSmsList(ipo.TemplateId, ipo.OperatorId);
            if (list == null || list.Count == 0)
                throw new Exception($"sms_template_sms没有有效的定义。templateId:{ipo.TemplateId} operatorId:{ipo.OperatorId}");
            var templateEo = MemCacheUtil.GetTemplateEo(ipo.TemplateId);
            var mode = templateEo.SelectSmsMode.ToEnum(SelectSmsMode.None);
            if (mode == SelectSmsMode.Order || mode == SelectSmsMode.None)
                return list.OrderBy(x => x.OrderNum).Select(x => x.SmsID).ToList();

            var first = string.Empty;
            switch (mode)
            {
                case SelectSmsMode.Avg:
                    first = list.ElementAt(new Random().Next(list.Count)).SmsID;
                    break;
                case SelectSmsMode.Weight:
                    first = MemCacheUtil.GetWeightTemplateSms(ipo.TemplateId, ipo.OperatorId).SmsID;
                    break;
                default:
                    throw new Exception($"XxyySmsUtil.SelectSmsItem没有找到sms。templateId:{ipo.TemplateId} operatorId:{ipo.OperatorId} mode:{mode}");
            }
            var ret = new List<string>
            {
                first
            };
            ret.AddRange(list.Where(x => x.SmsID != first).Select(x => x.SmsID).ToList());
            return ret;
        }

        private static async Task SetOrderEo(XxyySmsIpo ipo, Sms_sms_orderPO orderEo)
        {
            orderEo.OrderID = ObjectId.NewId();
            orderEo.TemplateID = ipo.TemplateId;
            orderEo.Mobile = ipo.Mobile;
            orderEo.RequestBody = SerializerUtil.SerializeJsonNet(ipo);
            orderEo.RecDate = orderEo.RequestTime = DateTime.UtcNow;
            if (!string.IsNullOrEmpty(ipo.AppId))
            {
                var app = MemCacheUtil.GetApp(ipo.AppId);
                orderEo.AppID = ipo.AppId;
                orderEo.ProviderID = app.ProviderID;
            }
            if (!string.IsNullOrEmpty(ipo.OperatorId))
            {
                var oper = MemCacheUtil.GetOperator(ipo.OperatorId);
                orderEo.OperatorID = ipo.OperatorId;
                orderEo.CountryID = oper.CountryID;
            }
        }
        private string GetContent(XxyySmsIpo ipo, Sms_sms_orderPO orderEo)
        {
            string content = null;
            if (!string.IsNullOrEmpty(ipo.Content))
            {
                content = ipo.Content;
            }
            else
            {
                var tmplLangEo = MemCacheUtil.GetTemplateLangEo(ipo.TemplateId, ipo.OperatorId, ipo.LangId);
                orderEo.LangID = tmplLangEo.LangID;
                content = (ipo.ContentArgs?.Count > 0)
                    ? string.Format(tmplLangEo.Content, ipo.ContentArgs.ToArray())
                    : tmplLangEo.Content;
            }
            return content;
        }
    }
}
