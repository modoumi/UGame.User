using SingleGame.Host.Games;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TinyFx.Extensions.DotNetty;
using Xxyy.GameEngine;

namespace SingleGame.Host.Cmds
{
    [Command]
    public class ExitCmd : GameCommand<ExitReq, ExitAck>
    {
        public override async Task<ExitAck> Respond(RequestContext ctx, ExitReq request)
        {
            var ret = new ExitAck();
            var dto = await Server.Exit(request.UserId);
            ret.UserId = dto.Player.UserId;
            return ret;
        }
    }
}
