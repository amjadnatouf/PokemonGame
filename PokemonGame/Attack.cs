namespace PokemonGame
{
    internal class Attack
    {
        public string Name { get; }
        public ElementType Type { get; }
        public int BasePower { get; }

        public Attack(string name, ElementType type, int basePower)
        {
            ArgumentException.ThrowIfNullOrWhiteSpace(name);
            if (basePower < 0)
                throw new ArgumentException("Base power cannot be negative", nameof(basePower));

            Name = name;
            Type = type;
            BasePower = basePower;
        }
        public virtual void Use(int level)
        {
            int totalPower = BasePower + level;
            Console.WriteLine($"{Name} hit with a total power of {totalPower}");
        }
    }
}