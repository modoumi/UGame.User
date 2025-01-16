using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TinyFx;
using TinyFx.Extensions.DotNetty;
using Xxyy.GameEngine;

namespace SingleGame.Host.Games
{
    public abstract class GameCommand<TReq, TAck> : GameCommandBase<GameServer, GameTable, GamePlayer, GameOptions, TReq, TAck>
    {
        public GameCommand()
        {
        }
    }
}
