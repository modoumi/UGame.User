using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UGame.User.Service.Common
{
    public static class XxyyCodes
    {

        #region Register
        public const string UsernameInvalid = "UsernameInvalid"; //注册时username无效
        public const string EmailInvalid = "EmailInvalid";//注册时email无效

        public const string NicknameExist = "NicknameExist"; //注册时Nickname已存在
        public const string PasswordDifferent = "PasswordDifferent"; //注册时密码不一致
        public const string SecurityCodeErr = "SecurityCodeErr";//安全码错误
        public const string MobileExist = "MobileExist"; //注册时登录Mobile已存在
        public const string UsernameExist = "UsernameExist"; //注册时登录用户名已存在
        public const string EmailExist = "EmailExist"; //注册时登录Email已存在
        public const string OAuthExist = "OAuthExist"; //注册时第三方账户已绑定过
        public const string NicknameInvalid = "NicknameInvalid"; //注册时nickname无效
        public const string RS_PUSER_NOT_EXISTS = "RS_PUSER_NOT_EXISTS";//推广用户不存在

        public const string RS_USER_REGISTED = "RS_USER_REGISTED"; //注册时已是注册用户
        #endregion

        #region Login
        public const string RS_USER_DISABLED = "UserStatusError"; // 用户状态异常
        public const string LoginErrorLimit = "LoginErrorLimit";// 登录错误次数过多，等待30分钟
        public const string UserPasswordError = "UserPasswordError"; // 登录密码错误
        public const string UserOauthUrlState = "state is not verify"; // 用于和请求AuthorizeUrl前的state比较，防止CSRF攻击
        #endregion
    }

}
