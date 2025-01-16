using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AiUo.Configuration;
using AiUo.Extensions.RabbitMQ;
using AiUo.Security;
using AiUo.Text;
using UGame.User.Service.Common;
using UGame.User.Common;
using UGame.User.Common.Caching;
using UGame.User.MQ.Xxyy;

namespace UGame.User.Service.Account
{
    public class ChangeService
    {
        private VerifyCodeService _vcodeSvc = new();
        private LimitedCharFilter _charFilter = new LimitedCharFilter(true, StringUtil.NumberLetterChars);

        public async Task ChangePassword(ChangePasswordIpo ipo)
        {
            var userMo = DbSink.BuildUserMo(ipo.UserId);
            var user = await userMo.GetByPKAsync(ipo.UserId);
            if (user == null)
                throw new Exception($"用户不存在。userId: {ipo.UserId}");

            if (!SecurityUtil.ValidatePassword(ipo.OldPassword, user.Password, user.PasswordSalt))
                throw new CustomException(XxyyCodes.UserPasswordError, "密码错误");
            var newPwd = SecurityUtil.EncryptPassword(ipo.NewPassword, user.PasswordSalt);
            await userMo.PutPasswordByPKAsync(ipo.UserId, newPwd);
        }
        public async Task ForgotPassword(ForgotPasswordIpo ipo)
        {
            var operatorEo = DbCacheUtil.GetOperator(ipo.OperatorId);
            var countryEo = DbCacheUtil.GetCountry(operatorEo.CountryID);
            if (!ipo.Mobile.StartsWith(countryEo.CallingCode))
                throw new Exception($"手机号码错误。mobile:{ipo.Mobile} countryId:{countryEo.CountryID} callingCode:{countryEo.CallingCode}");

            if (!_vcodeSvc.VerifySecurityCode(ipo.SecurityCode, ipo.Mobile, ipo.VerifyCode))
                throw new CustomException(XxyyCodes.SecurityCodeErr, $"安全码异常");
            var userId = await LoginCacheUtil.GetUserIdByMobile(ipo.OperatorId, ipo.Mobile);
            if (userId == null) {
                userId = await LoginCacheUtil.GetUserIdByUsername(ipo.OperatorId,ipo.Mobile.TrimStart(countryEo.CallingCode));
                if(userId == null)
                    throw new CustomException(CommonCodes.MobileNotExist, $"mobile不存在！Mobile: {ipo.Mobile}");
            }
                
            var userMo = DbSink.BuildUserMo(userId);
            var user = await userMo.GetByPKAsync(userId);
            if (user == null)
                throw new CustomException(CommonCodes.RS_USER_NOT_EXISTS, $"用户不存在！userId: {userId}");
            var newPwd = SecurityUtil.EncryptPassword(ipo.NewPassword, user.PasswordSalt);
            await userMo.PutPasswordByPKAsync(userId, newPwd);
        }

        public async Task ChangeMobile(ChangeMobileIpo ipo)
        {
            if (string.IsNullOrEmpty(ipo.UserId))
                throw new Exception("userId不能为空");
            var userMo = DbSink.BuildUserMo(ipo.UserId);
            var userEo = await userMo.GetByPKAsync(ipo.UserId);
            if (userEo == null)
                throw new Exception($"用户不存在。userid:{ipo.UserId}");

            var oper = DbCacheUtil.GetOperator(userEo.OperatorID);
            var countryEo = DbCacheUtil.GetCountry(oper.CountryID);
            if (string.IsNullOrEmpty(ipo.Mobile))
                throw new Exception("手机号码不能为空");
            if (!ipo.Mobile.StartsWith(countryEo.CallingCode))
                throw new Exception($"手机号码错误。mobile:{ipo.Mobile} countryId:{countryEo.CountryID} callingCode:{countryEo.CallingCode}");

            if (!_vcodeSvc.VerifySecurityCode(ipo.SecurityCode, ipo.Mobile, ipo.VerifyCode))
                throw new CustomException(XxyyCodes.SecurityCodeErr, $"注册时安全码异常");
            var oldUserId = await LoginCacheUtil.GetUserIdByMobile(userEo.OperatorID, ipo.Mobile);
            if (oldUserId != null && oldUserId != userEo.UserID)
                throw new CustomException(XxyyCodes.MobileExist, $"注册时登录Mobile已存在");

            bool isFirst = string.IsNullOrEmpty(userEo.Mobile);
            if (string.IsNullOrEmpty(ipo.NewPassword))
            {
                if (oldUserId == userEo.UserID)
                    return;
                await userMo.PutMobileByPKAsync(ipo.UserId, ipo.Mobile);
            }
            else
            {
                userEo.Mobile = ipo.Mobile;
                userEo.PasswordSalt = SecurityUtil.GetPasswordSalt();
                userEo.Password = SecurityUtil.EncryptPassword(ipo.NewPassword, userEo.PasswordSalt);
                await userMo.PutAsync(userEo);
            }
            await LoginCacheUtil.SetUserIdByMobile(userEo.OperatorID, ipo.Mobile, userEo.UserID);
            await MQUtil.PublishAsync<ChangeMobileMsg>(new ChangeMobileMsg()
            {
                UserId = ipo.UserId,
                OperatorId = userEo.OperatorID,
                CountryId = userEo.CountryID,
                CurrencyId = userEo.CurrencyID,
                Mobile = ipo.Mobile,
                IsFirst = isFirst
            });
        }

        public async Task ChangeNickname(ChangeNicknameIpo ipo)
        {
            if (string.IsNullOrEmpty(ipo.Nickname) || ipo.Nickname.Length < 6 || ipo.Nickname.Length > 30)
                throw new CustomException(XxyyCodes.NicknameInvalid, "Nickname不能为空且长度6-30");
            if (!_charFilter.IsValid(ipo.Nickname))
                throw new CustomException(XxyyCodes.NicknameInvalid, "Nickname仅允许字母和数字");

            var userMo = DbSink.BuildUserMo(ipo.UserId);
            var userEo = await userMo.GetByPKAsync(ipo.UserId);
            if (userEo == null)
                throw new Exception($"用户不存在。userid:{ipo.UserId}");

            await userMo.PutNicknameByPKAsync(ipo.UserId, ipo.Nickname);
            await new GlobalUserDCache(ipo.UserId).SetNicknameAsync(ipo.Nickname);
        }
    }
}
