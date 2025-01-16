using Microsoft.Extensions.Hosting;
using TinyFx;
using Xxyy;
using SingleGame.Host.Games;

namespace SingleGame.Host
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var builder = TinyFxHost.CreateBuilder(args)
                .UseGameServer<GameServer, GameTable, GamePlayer, GameOptions>()
                .Build();
            builder.Run();
        }
    }
}