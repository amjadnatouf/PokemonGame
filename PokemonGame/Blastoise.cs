
namespace PokemonGame
{
    internal sealed class Blastoise : WaterPokemon
    {
        public Blastoise(List<Attack> attacks, int currentLevel)
            : base("Blastoise", currentLevel, attacks)
        {
        }

        public override void Speak()
        {
            Console.WriteLine($"{Name} says: BLAAAST!");
        }
    }
}