using System;
using System.Collections.Generic;

namespace Hive
{
    public class Player
    {
        public readonly IReadOnlyCollection<Creature> AvailablePieces;

        public Player(IReadOnlyCollection<Creature> availablePieces)
        {
            AvailablePieces = availablePieces;
        }

    }
}