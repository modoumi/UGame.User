using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xxyy.GameEngine;

namespace SingleGame.Host.Games
{
    public class GameTable : SingleGameTable<GamePlayer>
    {
        public GameTable(string tableId) : base(tableId)
        {
        }
    }
}
