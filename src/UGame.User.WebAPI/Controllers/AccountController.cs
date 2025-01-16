using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using AiUo.AspNet;
using AiUo.AspNet.ClientSign;
using UGame.User.Service.Account;
using Xxyy.Common;

namespace UGame.User.WebAPI.Controllers
{
    /// <summary>
    /// 账户接口（仅我方运营商APP调用）
    /// </summary>
    [EnableCors()]
    [ClientSignFilter()]
    public class AccountController : AiUoControllerBase
    {
        private AccountService _accSvc = new();
        private VerifyCodeService _verifyCodeSvc = new();
        private ChangeService _changeSvc = new();

        #region VerifyCode
        /// <summary>
        /// 发送验证码
        /// SMSLimited - 短信验证码发送限制（频繁）
        /// </summary>
        /// <param name="ipo"></param>
        /// <returns></returns>
        [HttpPost]
        [AllowAnonymous]
        public async Task SendVerifyCode(SendVerifyCodeIpo ipo)
        {
            await _verifyCodeSvc.SendVerifyCode(ipo);
        }

        /// <summary>
        /// 验证验证码
        /// VerifyCodeError - 验证码错误
        /// </summary>
        /// <param name="ipo"></param>
        /// <returns></returns>
        [HttpPost]
        [AllowAnonymous]
        public async Task<CheckVerifyCodeDto> CheckVerifyCode(CheckVerifyCodeIpo ipo)
        {
            return await _verifyCodeSvc.CheckVerifyCode(ipo);
        }

        #endregion

        /// <summary>
        /// 新用户注册
        /// NicknameExist - 注册时Nickname已存在
        /// PasswordDifferent - 注册时密码不一致
        /// SecurityCodeErr - 安全码错误
        /// MobileExist - 注册时登录Mobile已存在
        /// UsernameExist - 注册时登录用户名已存在
        /// EmailExist - 注册时登录Email已存在
        /// UsernameInvalid
        /// RS_PUSER_NOT_EXISTS - 推广用户不存在
        /// </summary>
        /// <param name="ipo"></param>
        /// <returns></returns>
        [HttpPost]
        [AllowAnonymous]
        public async Task<RegisterDto> Register(RegisterIpo ipo)
        {
            if (ipo.Meta != null)
                ipo.Meta = JsonConvert.DeserializeObject(Convert.ToString(ipo.Meta));
            return await _accSvc.Register(ipo);
        }

        /// <summary>
        /// 登录
        /// MobileNotExist - mobile不存在
        /// UserStatusError - 用户状态异常
        /// LoginErrorLimit - 登录错误次数过多，等待30分钟
        /// UserPasswordError - 登录密码错误
        /// UsernameInvalid
        /// </summary>
        /// <param name="ipo"></param>
        /// <returns></returns>
        [HttpPost]
        [AllowAnonymous]
        public async Task<LoginDto> Login(LoginIpo ipo)
        {
            if(ipo.Meta!=null)
                ipo.Meta = JsonConvert.DeserializeObject(Convert.ToString(ipo.Meta));
            return await _accSvc.Login(ipo);
        }

        /// <summary>
        /// 重新登陆
        /// </summary>
        /// <param name="ipo"></param>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
        [HttpPost]
        public async Task<ReloginDto> Relogin(ReloginIpo ipo)
        {
            if (ipo.Meta != null)
                ipo.Meta = JsonConvert.DeserializeObject(Convert.ToString(ipo.Meta));
            ipo.UserId = UserId;
            return await _accSvc.Relogin(ipo);

        }

        /// <summary>
        /// 刷新JwtToken
        /// G_JwtTokenInvalid - 无效的token
        /// G_JwtTokenExpired - 过期的token
        /// </summary>
        /// <param name="ipo"></param>
        /// <returns></returns>
        [HttpPost]
        public async Task<string> RefreshJwtToken(RefreshJwtTokenIpo ipo)
        {
            if (ipo.UserId != UserId)
                throw new Exception("用户userId不匹配！");
            return await _accSvc.RefreshJwtToken(ipo);
        }
        /// <summary>
        /// 修改密码
        /// UserPasswordError - 登录密码错误
        /// </summary>
        /// <param name="ipo"></param>
        [HttpPost]
        public async Task ChangePassword(ChangePasswordIpo ipo)
        {
            if (ipo.UserId != UserId)
                throw new Exception("用户userId不匹配！");
            await _changeSvc.ChangePassword(ipo);
        }

        /// <summary>
        /// 修改手机号和重置密码
        /// MobileExist -- Mobile已存在
        /// </summary>
        /// <param name="ipo"></param>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
        [HttpPost]
        public async Task ChangeMobile(ChangeMobileIpo ipo)
        {
            if (ipo.UserId != UserId)
                throw new Exception("用户userId不匹配！");
            await _changeSvc.ChangeMobile(ipo);
        }

        /// <summary>
        /// 修改昵称
        /// NicknameInvalid
        /// NicknameExist
        /// </summary>
        /// <param name="ipo"></param>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
        [HttpPost]
        public async Task ChangeNickname(ChangeNicknameIpo ipo)
        {
            if (ipo.UserId != UserId)
                throw new Exception("用户userId不匹配！");
            await _changeSvc.ChangeNickname(ipo);
        }

        /// <summary>
        /// 忘记密码
        /// MobileNotExist - mobile不存在
        /// SecurityCodeErr - 安全码错误
        /// </summary>
        /// <param name="ipo"></param>
        [HttpPost]
        [AllowAnonymous]
        public async Task ForgotPassword(ForgotPasswordIpo ipo)
        {
            await _changeSvc.ForgotPassword(ipo);
        }

        /// <summary>
        /// 退出登录
        /// </summary>
        [HttpGet]
        [AllowAnonymous]
        public async Task Loginout()
        {
            await _accSvc.Loginout();
        }
    }
}
