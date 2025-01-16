using TinyFx;
using Xxyy;
using ApiGame.Host.Games;

namespace ApiGame.Host
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = AspNetHost.CreateBuilder(args);
            builder.Host.UseApiGameServer<GameServer,GamePlayer, GameOptions>();

            // Add services to the container.
            builder.Services.AddTinyFxEx(AspNetType.Api);
            var app = builder.Build();
            // Configure the HTTP request pipeline.
            app.UseTinyFxEx();

            app.UseAuthentication();
            app.UseAuthorization();
            app.MapControllers();
            app.Run();
        }
    }
}