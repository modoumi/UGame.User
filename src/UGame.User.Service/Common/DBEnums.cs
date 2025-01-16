using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UGame.User.Service.Common
{
    /// <summary>
    ///   Visitor = 1, 游客不登录，使用UserId即可
    ///  UsernameAndPassword = 2, 游客不登录，使用UserId即可
    /// EmailAndPassword = 3, Email+密码
    ///   MobileAndPassword = 4, 手机+密码
    ///  MobileAndSMSCode = 5 手机+短信验证码
    ///  JwtToken = 6  jwt token重新登录
    /// OAuth = 8 授权登陆
    /// </summary>
    public enum LoginMode
    {
        /// <summary>
        /// 游客不登录，使用UserId即可
        /// </summary>
        Visitor = 1,
        /// <summary>
        /// 用户名+密码
        /// </summary>
        UsernameAndPassword = 2,
        /// <summary>
        /// Email+密码
        /// </summary>
        EmailAndPassword = 3,
        /// <summary>
        /// 手机+密码
        /// </summary>
        MobileAndPassword = 4,
        /// <summary>
        /// 手机+短信验证码
        /// </summary>
        MobileAndSMSCode = 5,
        /// <summary>
        /// jwt token重新登录
        /// </summary>
        JwtToken = 6,
        /// <summary>
        /// 合作方用户
        /// </summary>
        PartnerVerify = 7,
        /// <summary>
        /// 授权登陆
        /// </summary>
        OAuth = 8
    }
}
