using ApiGame.Host.Games;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using TinyFx;
using TinyFx.AspNet;
using Xxyy.Caching;
using Xxyy.GameEngine;

namespace ApiGame.Host.Controllers
{
    public class GameController : TinyFxControllerBase
    {
        private GameServer Server { get; set; }
        private GameOptions Options { get; set; }
        private GamePlayer Player 
        {
            get
            {
                var userId = UserId;
                return !string.IsNullOrEmpty(userId) ? Server.GetPlayer(userId) : null;
            }
        }
        public GameController()
        {
            Server = DIUtil.GetRequiredService<GameServer>();
            Options = DIUtil.GetRequiredService<GameOptions>();
        }
        [HttpPost]
        public HeartAck Bet(HeartReq req)
        {
            var ret = new HeartAck();
            new UserAppDCache(req.UserId, Options.AppId).ActiveDate = DateTime.Now;
            ret.UserId = UserId;
            return ret;
        }
    }
}
