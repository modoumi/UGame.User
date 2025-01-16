using System.ComponentModel;
using System.Text.Json;
using System.Text.Json.Serialization;
using AiUo.Extensions.AutoMapper;
using AiUo.Net;
using AiUo.OAuth;
using UGame.User.Service.Common;
using UGame.User.Common;
using UGame.User.Common.Caching;
using Xxyy.Common;


namespace UGame.User.Service.Account
{
    /// <summary>
    /// 注册输入参数
    /// </summary>
    public class RegisterIpo: IClientInfo
    {
        /// <summary>
        /// 应用编码
        /// </summary>
        public string AppId { get; set; }
        /// <summary>
        /// 运营商平台编码
        /// </summary>
        public string OperatorId { get; set; }

        /// <summary>
        /// 登录模式 
        /// 1-游客
        /// 2-用户名+密码
        /// 3-Email+密码
        /// 4-手机+密码
        /// 5-手机+短信验证码
        /// </summary>
        public LoginMode LoginMode { get; set; }

        /// <summary>
        /// 游客转注册用户必须提供UserId
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
        /// 重复密码
        /// </summary>
        public string RepeatPassword { get; set; }
        /// <summary>
        /// 昵称
        /// </summary>
        public string Nickname { get; set; }
        /// <summary>
        /// 验证码
        /// </summary>
        public string VerifyCode { get; set; }
        /// <summary>
        /// 安全码
        /// </summary>
        public string SecurityCode { get; set; }
        /// <summary>
        /// 来源渠道
        ///     0-运营商新用户
        ///     1-推广员用户 uid
        ///     2-渠道推广 cid
        /// </summary>
        public int FromMode { get; set; }
        public string FromId { get; set; }
        
        public string IMEI { get; set; }
        public string GAID { get; set; }
        public string VersionId { get; set; }
        public string Language { get; set; }
        /// <summary>
        /// 用户第一次进入客户端时的url
        /// </summary>
        public string ClientUrl { get; set; }
        public OperatingSystemType OS { get; set; }
        public BrowserType Browser { get; set; }
        public bool IsMobile { get; set; }
        public UserKind UserKind { get; set; } = UserKind.User;

        public dynamic Meta { get; set; }

        public int OAuthType { get; set; } =0;

        public string OAuthID { get; set; }
    }

    public class OAuthLoginIpo : IMapFrom<RegisterIpo>,IMapTo<RegisterIpo>
    {
        /// <summary>
        /// 应用编码
        /// </summary>
        public string AppId { get; set; }
        /// <summary>
        /// 运营商平台编码
        /// </summary>
        public string OperatorId { get; set; }

        /// <summary>
        /// 登录模式 
        /// 1-游客
        /// 2-用户名+密码
        /// 3-Email+密码
        /// 4-手机+密码
        /// 5-手机+短信验证码
        /// 8授权登陆
        /// </summary>
        public LoginMode LoginMode { get; set; }

        /// <summary>
        /// 游客转注册用户必须提供UserId
        /// </summary>
        public string UserId { get; set; }
 
        /// <summary>
        /// 安全码
        /// </summary>
        public string SecurityCode { get; set; }
        /// <summary>
        /// 来源渠道
        ///     0-运营商新用户
        ///     1-推广员用户 uid
        ///     2-渠道推广 cid
        /// </summary>
        public int FromMode { get; set; }
        public string FromId { get; set; }

        public string IMEI { get; set; }
        public string GAID { get; set; }
        public string VersionId { get; set; }
        public string Language { get; set; }
        /// <summary>
        /// 用户第一次进入客户端时的url
        /// </summary>
        public string ClientUrl { get; set; }
        public OperatingSystemType OS { get; set; }
        public BrowserType Browser { get; set; }
        public bool IsMobile { get; set; }
        public UserKind UserKind { get; set; } = UserKind.User;

        public dynamic Meta { get; set; }

        public OAuthUserIpo OAuthUserIpo { get; set; }
        public void MapFrom(RegisterIpo source)
        {
            //AuthCallbackIpo = null;
            //throw new NotImplementedException();
        }

        public void MapTo(RegisterIpo destination)
        {
            //throw new NotImplementedException();
        }
    }
    public class AuthUrlIpo
    {
       
        public OAuthProviders OAuthProvider { get; set; }
        /// <summary>
        /// 三方跳转url
        /// </summary>
        public string RedirectUri { get; set; }
    }

    /// <summary>
    /// 注册返回参数
    /// </summary>
    public class RegisterDto : LoginDto, IMapFrom<LoginDto>
    {
        public void MapFrom(LoginDto source)
        {

        }
    }
}
