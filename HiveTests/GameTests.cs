using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using Hive;
using Xunit;

namespace HiveTests
{
    public class GameTests
    {
        [Fact]
        public void WhenAGameIsStartedItContainsAPlayerWithAQueenBee()
        {
            var initialPieces = new List<Creature>() {new QueenBee()};
            var players = new Collection<Player>() {new Player(initialPieces)};
            var game = new Game(players);
            
            var initialState = game.InitialState();
            
            Assert.Equal(1, initialState.Players.Count);
            Assert.IsType<QueenBee>(initialState.Players.Single().AvailablePieces.Single());
        }
    }
}