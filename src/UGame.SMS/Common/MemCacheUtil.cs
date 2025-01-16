using Microsoft.AspNetCore.DataProtection.KeyManagement;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using AiUo;
using AiUo.Caching;
using AiUo.DbCaching;
using AiUo.Randoms;
using UGame.SMS.DAL;

namespace UGame.SMS.Common
{
    internal static class MemCacheUtil
    {
        static MemCacheUtil()
        {
            DbCachingUtil.GetCache<Sms_template_langPO>().UpdateCallback = (_, _) =>
            {
                _targetLangEoDict.Clear();
            };
        }

        #region s_app
        public static S_appPO GetApp(string appId, bool exceptionOnNull = true, string errorCode = null)
        {
            var ret = DbCachingUtil.GetSingle<S_appPO>(appId);

            if (ret == null)
            {
                if (exceptionOnNull)
                {
                    if (string.IsNullOrEmpty(errorCode))
                        throw new Exception($"AppId不存在: {appId}");
                    else
                        throw new CustomException(errorCode, $"AppId不存在: {appId}");
                }
                else
                    return null;
            }
            return ret;
        }
        #endregion

        #region s_operator
        public static S_operatorPO GetOperator(string operatorId, bool excOnNull = true, string errorCode = null)
        {
            var ret = DbCachingUtil.GetSingle<S_operatorPO>(it => it.OperatorID, operatorId);
            if (ret == null)
            {
                if (excOnNull)
                {
                    if (string.IsNullOrEmpty(errorCode))
                        throw new Exception($"无效的operatorId: {operatorId}");
                    else
                        throw new CustomException(errorCode, $"无效的operatorId: {operatorId}");
                }
                else
                    return null;
            }
            return ret;
        }

        private static List<string> GetOperatorLangs(string operatorId)
        {
            var ret = new List<string>();
            var oper = GetOperator(operatorId);
            if (!string.IsNullOrEmpty(oper.Langs))
                ret = oper.Langs.Split('|').ToList();
            return ret;
        }
        #endregion

        #region sms_sms
        public static Sms_smsPO GetSmsEo(string smsId)
        {
            var ret = DbCachingUtil.GetSingle<Sms_smsPO>(smsId);
            if (ret == null)
                throw new Exception($"sms_sms表smsId不存在: {smsId}");
            return ret;
        }
        #endregion

        #region sms_template
        public static Sms_templatePO GetTemplateEo(int templateId)
        {
            var ret = DbCachingUtil.GetSingle<Sms_templatePO>(templateId);
            if (ret == null)
                throw new Exception($"sms_template表templateId不存在: {templateId}");
            return ret;
        }
        public static Sms_templatePO GetTemplateEo(string appId)
        {
            var list = DbCachingUtil.GetList(() => new Sms_templatePO
            {
                AppID = appId,
                TemplateType = 1
            });
            var ret = list.FirstOrDefault();
            if (ret == null)
                throw new Exception($"sms_template没有TemplateType=1且AppId={appId}的数据");
            return ret;
        }
        #endregion

        #region sms_template_lang
        private static Dictionary<string, Sms_template_langPO> _targetLangEoDict = new();
        public static Sms_template_langPO GetTemplateLangEo(int templateId, string operatorId, string langId)
        {
            var key = $"{templateId}|{operatorId}|{langId}";
            if (_targetLangEoDict.TryGetValue(key, out var ret))
                return ret;
            var list = DbCachingUtil.GetList<Sms_template_langPO>(it => it.TemplateID, templateId);
            // langId
            if (!string.IsNullOrEmpty(langId))
            {
                ret = list.FirstOrDefault(x => x.LangID == langId, null);
            }
            // operator第一个默认
            if (ret == null && !string.IsNullOrEmpty(operatorId))
            {
                var operLangs = GetOperatorLangs(operatorId);
                var operLangId = operLangs?.FirstOrDefault();
                if (!string.IsNullOrEmpty(operLangId))
                    ret = list.FirstOrDefault(x => x.LangID == operLangId, null);
            }
            // 第一个默认
            if (ret == null)
            {
                ret = list.FirstOrDefault();
            }
            if (ret == null)
                throw new Exception($"DbCacheUtil.GetTemplateLangEo没有获取到值。templateId:{templateId} operatorId:{operatorId} langId:{langId}");
            _targetLangEoDict.TryAdd(key, ret);
            return ret;
        }
        #endregion

        #region v_sms_template_sms
        public static List<Sms_template_smsPO> GetTemplateSmsList(int templateId, string operatorId)
        {
            return DbCachingUtil.GetList(() => new Sms_template_smsPO
            {
                TemplateID = templateId,
                OperatorID = operatorId
            });
        }
        public static Sms_template_smsPO GetWeightTemplateSms(int templateId, string operatorId)
        {
            var provider = new WeightRandomProvider<Sms_template_smsPO>();
            var list = GetTemplateSmsList(templateId, operatorId);
            list.ForEach(x => provider.AddItem(x.Weight, x));
            return provider.Next();
        }
        #endregion
    }
}
