using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UGame.User.Service.Account
{
    public class ForgotPasswordIpo
    {
        public string Mobile { get; set; }
        /// <summary>
        /// 验证码
        /// </summary>
        public string VerifyCode { get; set; }
        /// <summary>
        /// 安全码
        /// </summary>
        public string SecurityCode { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string NewPassword { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string OperatorId { get; set; }
    }
}
