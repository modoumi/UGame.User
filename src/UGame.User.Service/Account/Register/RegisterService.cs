using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using AiUo.Text;
using UGame.User.Service.Common;
using UGame.User.Common; 
using Xxyy.Common;

namespace UGame.User.Service.Account.Register
{
    internal class RegisterService
    {
        private static UsernameFilter _usernameFilter = new();
        public async Task<LoginDto> Execute(RegisterIpo ipo)
        {
            var context = new RegisterContext(ipo);
            await CheckContext(context);
            return null;
        }
        private async Task CheckContext(RegisterContext context)
        {
            // visitor
            if (!context.OperatorEo.AllowVisitor && context.Ipo.LoginMode == LoginMode.Visitor)
                throw new Exception($"平台不允许游客注册");
            // mobile
            if (!string.IsNullOrEmpty(context.Ipo.Mobile) && !context.Ipo.Mobile.StartsWith(context.CountryEo.CallingCode))
                throw new Exception($"手机号码没有区号。mobile:{context.Ipo.Mobile} countryId:{context.CountryEo.CountryID} callingCode:{context.CountryEo.CallingCode}");
            // username
            if (!string.IsNullOrEmpty(context.Ipo.Username) && !_usernameFilter.IsValid(context.Ipo.Username))
                throw new CustomException(XxyyCodes.UsernameInvalid, "username仅允许6-30位的字母,数字和.");
            if (!string.IsNullOrEmpty(context.Ipo.Email) && !IsEmail(context.Ipo.Email))
                throw new CustomException(XxyyCodes.EmailInvalid, "email格式不正确");

            // nickname
            if (string.IsNullOrEmpty(context.Ipo.Nickname))
                context.Ipo.Nickname = $"G-{ObjectId.NewId()}";
            // fromMode fromId
            if (!await CheckFromData(context))
            {
                context.Ipo.FromMode = (int)FromMode.Operator;
                context.Ipo.FromId = context.Ipo.OperatorId;
            }
        }

        public bool IsEmail(string email) // "^\w+([-+.]\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*$"
        {
            if (string.IsNullOrEmpty(email))
                return false;
            var ret = Regex.IsMatch(email, @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$");
            return ret;
        }

        private async Task<bool> CheckFromData(RegisterContext context)
        {
            var fromMode = context.Ipo.FromMode.ToEnum(FromMode.Unknow);
            if (fromMode == FromMode.Unknow || string.IsNullOrEmpty(context.Ipo.FromId))
                return false;
            if (fromMode == FromMode.Promoter)
            {
                context.PUserEo = await DbSink.BuildUserMo(context.Ipo.FromId).GetByPKAsync(context.Ipo.FromId);
                return context.PUserEo != null;
            }
            return true;
        }
    }
}
