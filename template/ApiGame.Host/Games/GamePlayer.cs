using TinyFx.Extensions.DotNetty;
using Xxyy.GameEngine;

namespace ApiGame.Host.Games
{
    public class GamePlayer : ApiGamePlayer
    {
        public GameData Data { get; }
        public GamePlayer(string userId, AppSession session) : base(userId, session)
        {
            Data = new GameData();
        }
    }
}
