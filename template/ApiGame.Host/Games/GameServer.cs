using Xxyy.GameEngine;
using Xxyy.MQ;

namespace ApiGame.Host.Games
{
    public class GameServer : ApiGameServer<GamePlayer, GameOptions>
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
