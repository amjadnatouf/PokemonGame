
namespace PokemonGame
{
    internal class Game
    {
        private List<Pokemon> _pokemons = new List<Pokemon>();
        private Dictionary<ElementType, List<Attack>> _availableAttacks = new Dictionary<ElementType, List<Attack>>();

        public Game()
        {
            InitializeAttacks();
            InitializePokemons();
        }


        private void InitializeAttacks()
        {
            // Normal Fire attacks
            Attack flamethrower = new Attack("Flamethrower", ElementType.Fire, 12);
            Attack ember = new Attack("Ember", ElementType.Fire, 6);
            // Legendary Fire attacks
            Attack legendaryFlamethrower = new LegendaryAttack(flamethrower);

            // Normal Water attacks
            Attack watergun = new Attack("Water Gun", ElementType.Water, 8);
            Attack hydropump = new Attack("Hydro Pump", ElementType.Water, 15);
            // Legendary Water attacks
            Attack legendaryHydropump = new LegendaryAttack(hydropump);

            // Normal Grass attacks
            Attack vinewhip = new Attack("Vine Whip", ElementType.Grass, 7);
            Attack razorleaf = new Attack("Razor Leaf", ElementType.Grass, 11);
            // Legendary Grass attacks
            Attack legendaryRazorleaf = new LegendaryAttack(razorleaf);

            _availableAttacks[ElementType.Fire] = new List<Attack> { flamethrower, ember, legendaryFlamethrower };
            _availableAttacks[ElementType.Water] = new List<Attack> { watergun, hydropump, legendaryHydropump };
            _availableAttacks[ElementType.Grass] = new List<Attack> { vinewhip, razorleaf, legendaryRazorleaf };
        }


        private void InitializePokemons()
        {
            _pokemons.Add(new Charmander(_availableAttacks[ElementType.Fire]));
            _pokemons.Add(new Squirtle(_availableAttacks[ElementType.Water]));
            _pokemons.Add(new Bulbasaur(_availableAttacks[ElementType.Grass]));
        }
        public void Start()
        {
            Console.WriteLine("=== Pokemon Trainer Simulator ===\n");

            foreach (Pokemon pokemon in _pokemons)
            {
                try
                {
                    Console.WriteLine($"\n--- Training {pokemon.Name} (Type: {pokemon.Type}) ---");

                    // Perform random attack
                    pokemon.RandomAttack();

                    // Perform user attack
                    if (pokemon.Name == "Charmander")
                        pokemon.Attack();

                    // Check if evolvable and evolve
                    if (pokemon is IEvolvable evolvable)
                    {
                        Console.WriteLine($"\n{pokemon.Name} can evolve!");
                        evolvable.Evolve();
                    }

                    // Raise level
                    pokemon.RaiseLevel();

                    Console.WriteLine(new string('-', 50));
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error training {pokemon.Name}: {ex.Message}");
                }
            }

            Console.WriteLine("\nTraining Complete.......");
        }
    }
}