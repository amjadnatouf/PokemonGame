using System.Diagnostics.CodeAnalysis;

namespace PokemonGame
{
    internal class Pokemon
    {
        private string _name = null!;
        private int _level;
        private List<Attack> _attacks = null!;

        public string Name
        {
            get => _name;
            [MemberNotNull(nameof(_name))]
            protected set
            {
                ArgumentException.ThrowIfNullOrWhiteSpace(value, nameof(value));
                if (value.Length < 2 || value.Length > 15)
                    throw new ArgumentException("Name must be between 2 and 15 characters", nameof(value));
                _name = value;
            }
        }

        public int Level
        {
            get => _level;
            protected set
            {
                if (value < 1)
                    throw new ArgumentException("Level must be at least 1", nameof(value));
                _level = value;
            }
        }
        public ElementType Type { get; protected set; }

        public List<Attack> Attacks
        {
            get => _attacks;
            [MemberNotNull(nameof(_attacks))]
            set
            {
                ArgumentNullException.ThrowIfNull(value, nameof(value));
                if (value.Count == 0)
                    throw new ArgumentException("Pokemon must have at least one attack", nameof(value));
                _attacks = value;
            }
        }

        public Pokemon(string name, int level, ElementType type, List<Attack> attacks)
        {
            Name = name;
            Level = level;
            Type = type;
            Attacks = attacks;
        }
    }
}
