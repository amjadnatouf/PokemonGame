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

        public void RandomAttack()
        {
            Random random = new Random();
            int index = random.Next(Attacks.Count);
            Attack selectedAttack = Attacks[index];
            Console.WriteLine($"{Name} uses {selectedAttack.Name}!");
            selectedAttack.Use(Level);
        }

        public void Attack()
        {
            Console.WriteLine($"\n{Name}'s available attacks:");
            for (int i = 0; i < Attacks.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {Attacks[i].Name} (Type: {Attacks[i].Type}, Power: {Attacks[i].BasePower})");
            }

            Console.Write("Choose an attack (enter number): ");
            if (int.TryParse(Console.ReadLine(), out int choice) && choice >= 1 && choice <= Attacks.Count)
            {
                Attack selectedAttack = Attacks[choice - 1];
                Console.WriteLine($"{Name} uses {selectedAttack.Name}!");
                selectedAttack.Use(Level);
            }
            else
            {
                Console.WriteLine("Invalid choice! Using random attack instead.");
                RandomAttack();
            }
        }

        public void RaiseLevel()
        {
            Level++;
            Console.WriteLine($"{Name} leveled up! New level: {Level}");
        }
    }
}
