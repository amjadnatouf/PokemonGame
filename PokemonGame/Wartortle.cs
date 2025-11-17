
namespace PokemonGame
{
    internal class Wartortle : WaterPokemon, IEvolvable
    {
        private const int EvolveAtLevel = 36;

        public Wartortle(List<Attack> attacks, int currentLevel)
            : base("Wartortle", currentLevel, attacks)
        {
        }

        public override void Speak()
        {
            Console.WriteLine($"{Name} says: Wartor wartor!");
        }

        public override Pokemon RaiseLevel()
        {
            base.RaiseLevel();

            if (Level >= EvolveAtLevel)
            {
                return Evolve();
            }
            return this;
        }

        public Pokemon Evolve()
        {
            Console.WriteLine($"Now it's a Blastoise at level {Level}");
            return new Blastoise(Attacks, Level);
        }
    }
}