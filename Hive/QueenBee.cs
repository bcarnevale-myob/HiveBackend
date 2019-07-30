namespace Hive
{
    public class QueenBee : ICreature
    {
        public string Tile => this.GetType().Name;
    }
}