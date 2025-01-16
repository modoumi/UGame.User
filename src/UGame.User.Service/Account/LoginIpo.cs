using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AiUo.Net;
using UGame.User.Service.Common;
using UGame.User.Common.Caching;

namespace UGame.User.Service.Account
{
    public class LoginIpo: IClientInfo
    {
        public LoginMode LoginMode { get; set; }
        public string AppId { get; set; }
        public string OperatorId { get; set; }
        /// <summary>
        /// 用户id，游客登录用
        /// </summary>
        public string UserId { get; set; }
        /// <summary>
        /// 用户名
        /// </summary>
        public string Username { get; set; }
        /// <summary>
        /// Email
        /// </summary>
        public string Email { get; set; }
        /// <summary>
        /// 手机号
        /// </summary>
        public string Mobile { get; set; }
        /// <summary>
        /// 密码
        /// </summary>
        public string Password { get; set; }
        /// <summary>
        /// 验证码
        /// </summary>
        public string VerifyCode { get; set; }

        public string VersionId { get; set; }
        public string Language { get; set; }
        public OperatingSystemType OS { get; set; }
        public BrowserType Browser { get; set; }
        public bool IsMobile { get; set; }
        /// <summary>
        ///  登录附加
        /// </summary>
        public dynamic Meta { get; set; }
    }
}
