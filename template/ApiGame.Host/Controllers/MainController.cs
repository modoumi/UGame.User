using ApiGame.Host.Games;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TinyFx;
using TinyFx.AspNet;
using Xxyy.Caching;
using Xxyy.GameEngine;

namespace ApiGame.Host.Controllers
{
    public class MainController : TinyFxControllerBase
    {
        private GameServer Server { get; set; }
        private GameOptions Options { get; set; }
        public MainController()
        {
            Server = DIUtil.GetRequiredService<GameServer>();
            Options = DIUtil.GetRequiredService<GameOptions>();
        }

        [HttpPost]
        [AllowAnonymous]
        public async Task<EntryAck> Entry(EntryReq req)
        {
            var ret = new EntryAck();
            var dto = await Server.Entry(req.UserId, req.LoginTicket, null);
            ret.IsReconnect = dto.IsReconnect;
            ret.HeartInterval = Options.UserActiveExpiry / 3;
            return ret;
        }

        [HttpPost]
        [AllowAnonymous]
        public HeartAck Heart(HeartReq req)
        {
            var ret = new HeartAck();
            new UserAppDCache(req.UserId, Options.AppId).ActiveDate = DateTime.Now;
            ret.UserId = UserId;
            return ret;
        }

        [HttpPost]
        [AllowAnonymous]
        public async Task<ExitAck> Exit(ExitReq req)
        {
            var ret = new ExitAck();
            var dto = await Server.Exit(req.UserId);
            ret.UserId = dto.Player.UserId;
            return ret;
        }
    }
}
