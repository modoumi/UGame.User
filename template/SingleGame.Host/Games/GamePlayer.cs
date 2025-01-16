using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TinyFx.Extensions.DotNetty;
using Xxyy.GameEngine;

namespace SingleGame.Host.Games
{
    public class GamePlayer : SingleGamePlayer
    {
        public GamePlayer(string userId, AppSession session) : base(userId, session)
        {
        }
    }
}
