
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
            for (int round = 1; round <= 20; round++)
            {
                Console.WriteLine($"\n------ TRAINING ROUND {round} ------");

                for (int i = 0; i < _pokemons.Count; i++)
                {
                    try
                    {
                        Pokemon pokemon = _pokemons[i];
                        Console.WriteLine($"\n--- Training {pokemon.Name} (Type: {pokemon.Type}, Level: {pokemon.Level}) ---");

                        // Speak
                        pokemon.Speak();

                        // Raise level
                        pokemon.RaiseLevel();

                        // Check if evolved and replace in list
                        if (pokemon is IEvolvable evolvable && pokemon.Level >= GetEvolutionLevel(pokemon))
                        {
                            Pokemon evolvedPokemon = evolvable.Evolve();
                            _pokemons[i] = evolvedPokemon;
                            pokemon = evolvedPokemon;
                        }

                        // Perform random attack
                        pokemon.RandomAttack();

                        Console.WriteLine(new string('-', 60));
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine($"Error training Pokemon: {ex.Message}");
                    }
                }
            }

            Console.WriteLine("\nTraining Complete.......");
            Console.WriteLine(new string('-', 60));
            Console.WriteLine("\nFinal Pokemon Team:");
            foreach (var pokemon in _pokemons)
            {
                Console.WriteLine($"- {pokemon.Name} (Type: {pokemon.Type}, Level: {pokemon.Level})");
            }
        }

        private int GetEvolutionLevel(Pokemon pokemon)
        {
            return pokemon switch
            {
                Charmander => 16,
                Charmeleon => 36,
                Squirtle => 16,
                Wartortle => 36,
                Bulbasaur => 16,
                Ivysaur => 32,
                _ => int.MaxValue
            };
        }
    }
}