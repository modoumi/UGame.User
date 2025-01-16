using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UGame.User.Service.Account
{
    /// <summary>
    /// 发送验证码IPO
    /// </summary>
    public class SendVerifyCodeIpo
    {
        public VerifyCodeMode Mode { get; set; }
        /// <summary>
        /// 验证码标识，如mobile或者email
        /// </summary>
        public string Id { get; set; }
        public string OperatorId { get; set; }
        public string AppId { get; set; }
        public string LangId { get; set; }
    }
    public class CheckVerifyCodeIpo
    {
        public VerifyCodeMode Mode { get; set; }
        /// <summary>
        /// 验证码标识，如mobile或者email
        /// </summary>
        public string Id { get; set; }
        public string VerifyCode { get; set; }
    }
    public class CheckVerifyCodeDto
    {
        /// <summary>
        /// 安全码
        /// </summary>
        public string SecurityCode { get; set; }
    }
    public enum VerifyCodeMode
    {
        Mobile = 0,
        Email = 1
    }
}
