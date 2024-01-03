namespace Tak
{
    public class Stone
    {
        public StoneType Type;
        public int Owner;
        public bool IsCap => Type == StoneType.Cap;

        public Stone(int owner, StoneType type)
        {
            Owner = owner;
            Type = type;
        }

        public override string ToString()
        {
            return $"({Owner}{Type})";
        }
    }

    public enum StoneType
    {
        Flat,
        Wall,
        Cap
    }
}