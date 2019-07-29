using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace Hive
{
    public class Game
    {
        private readonly IReadOnlyCollection<Player> _players;

        public Game(IReadOnlyCollection<Player> players)
        {
            _players = players;
        }
        
        public GameState InitialState()
        {
            return new GameState(_players);
        }
    }
}