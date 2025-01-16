using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xxyy.GameEngine;
using Xxyy.MQ;

namespace SingleGame.Host.Games
{
    public class GameServer : SingleGameServer<GameTable, GamePlayer, GameOptions>
    {
        protected override Task DoStartAsync(CancellationToken stoppingToken)
        {
            return Task.CompletedTask;
        }

        protected override Task DoStopAsync(CancellationToken cancellationToken)
        {
            return Task.CompletedTask;
        }
        public override Task HandlerSubscribe(GameSubMessage message)
        {
            return Task.CompletedTask;
        }

        public override Task HandlerUserOffline(GamePlayer player)
        {
            return Task.CompletedTask;
        }
    }
}
