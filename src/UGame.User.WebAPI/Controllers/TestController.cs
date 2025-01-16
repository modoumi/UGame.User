using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Diagnostics.NETCore.Client;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using AiUo.AspNet;
using AiUo.Configuration;
using AiUo.Data.SqlSugar;
using AiUo.Logging;
using AiUo.Net;
using AiUo.Reflection;
using AiUo.Security;
using UGame.User.Service.InitApp;
using Xxyy.Common;
using Xxyy.Common.Caching;
using Xxyy.Common.Services;
using Xxyy.DAL;
using UGame.DataMove.Common;

namespace UGame.User.WebAPI.Controllers
{
    [EnableCors()]
    public class TestController : AiUoControllerBase
    {
        [HttpGet]
        [AllowAnonymous]
        public async Task<List<string>> Test()
        {
            var ret = new List<string>();
            return ret;
        }
    }
}
