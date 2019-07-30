using System;
using System.Collections.Generic;

namespace Hive
{
    public class Player
    {
        public readonly IReadOnlyCollection<ICreature> AvailablePieces;

        public Player(IReadOnlyCollection<ICreature> availablePieces)
        {
            AvailablePieces = availablePieces;
        }

    }
}