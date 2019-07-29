using System.Collections.Generic;

namespace Hive
{
    public class GameState
    {
        public readonly IReadOnlyCollection<Player> Players;

        public GameState(IReadOnlyCollection<Player> players)
        {
            Players = players;
        }
    }
}