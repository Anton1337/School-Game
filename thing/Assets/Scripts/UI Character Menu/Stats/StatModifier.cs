namespace Anton.CharacterStats
{
    public class StatModifier
    {

        public readonly int Value;
        public readonly object Source;

        public StatModifier(int value, object source)
        {
            Value = value;
            Source = source;
        }
    }
}
