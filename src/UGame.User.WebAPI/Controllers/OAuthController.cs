using System.Collections.Concurrent;
using System.Web;
using Microsoft.AspNetCore.Cors;
using AiUo.AspNet;
using AiUo.Common;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using AiUo.Extensions.AutoMapper;
using UGame.User.Service.Account;

using AiUo.Common.Caching;
using UGame.User.Service.Common;
using AutoMapper;
using System.Collections.Generic;
using AiUo;
using AiUo.OAuth;
using AiUo.AspNet.ClientSign;

namespace UGame.User.WebAPI.Controllers
{
    [EnableCors()]
    [ClientSignFilter()]
    public class OAuthController: AiUoControllerBase
    {
        private AccountService _accSvc = new();
       
        public OAuthController( )
        {
         
        }
        /// <summary>
        /// 获取第三方app授权登录url
        /// </summary>
        /// <param name="authUrlIpo"></param>
        /// <returns></returns>
        [HttpPost]
        [AllowAnonymous]
        public async Task<string> OAuthUrl(AuthUrlIpo authUrlIpo)
        {
            return await OAuthUtil.GetOAuthUrl(authUrlIpo.OAuthProvider, authUrlIpo.RedirectUri);
        }

        /// <summary>
        /// 跳转三方返回页面执行此方法获取三方用户信息并且注册登录
        /// </summary>
        /// <param name="oaAuthLoginIpo"></param>
        /// <returns></returns>
        [HttpPost]
        [AllowAnonymous]
        public async Task<LoginDto> OAuthLogin(OAuthLoginIpo oaAuthLoginIpo)
        {
            //获取三方系统用户信息
            var userInfo = await OAuthUtil.GetUserInfo(oaAuthLoginIpo.OAuthUserIpo);
            if (userInfo == null||userInfo.Success==false)
            {
                throw new CustomException("errors");
            }
            return await _accSvc.OAuthRegisterLogin(oaAuthLoginIpo, userInfo.Result);

        }
    }
}
