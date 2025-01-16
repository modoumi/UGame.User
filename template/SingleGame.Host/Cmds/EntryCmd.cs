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
    [Command(CheckLogin = false)]
    public class EntryCmd : GameCommand<EntryReq, EntryAck>
    {
        public override async Task<EntryAck> Respond(RequestContext ctx, EntryReq request)
        {
            var ret = new EntryAck();
            //var dto = await Server.Entry(request.UserId, request.LoginTicket, null);
            //ret.IsReconnect = dto.IsReconnect;
            ret.HeartInterval = Options.UserActiveExpiry / 3;
            return ret;
        }
    }
}
