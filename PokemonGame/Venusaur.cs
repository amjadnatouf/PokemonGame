
namespace PokemonGame
{
    internal class Venusaur : GrassPokemon
    {
        public Venusaur(List<Attack> attacks, int currentLevel)
        : base("Venusaur", currentLevel, attacks)
        {
        }

        public override void Speak()
        {
            Console.WriteLine($"{Name} says: SAAAUUUR!");
        }
    }
}