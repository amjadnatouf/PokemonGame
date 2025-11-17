
namespace PokemonGame
{
    internal class Charizard : FirePokemon
    {
        public Charizard(List<Attack> attacks, int currentLevel)
            : base("Charizard", currentLevel, attacks)
        {
        }

        public override void Speak()
        {
            Console.WriteLine($"{Name} says: ROAAAR!");
        }
    }
}