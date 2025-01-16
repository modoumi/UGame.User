using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using AiUo.AspNet;
using UGame.User.Service.Account;
using UGame.User.Service.InitApp;

namespace UGame.User.WebAPI.Controllers
{
    [EnableCors()]
    public class InitAppController : AiUoControllerBase
    {
        private InitAppService _initAppSvc = new();
        private AccountService _accSvc = new();

        /// <summary>
        /// 供应商app初始化（自研游戏调用）
        /// </summary>
        /// <param name="ipo"></param>
        /// <returns></returns>
        [HttpPost]
        [AllowAnonymous]
        public async Task<InitProviderAppDto> InitProviderApp(InitProviderAppIpo ipo)
        {
            return await _initAppSvc.InitProviderApp(ipo);
        }

        /// <summary>
        /// 运营商app初始化（自研lobby调用）
        /// RS_WRONG_COUNTRY: 非法国家IP访问
        /// </summary>
        /// <param name="ipo"></param>
        /// <returns></returns>
        [HttpPost]
        [AllowAnonymous]
        public async Task<InitOperatorAppDto> InitOperatorApp(InitOperatorAppIpo ipo)
        {
            return await _initAppSvc.InitOperatorApp(ipo);
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
    }
}
