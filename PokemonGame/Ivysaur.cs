
namespace PokemonGame
{
    internal class Ivysaur : GrassPokemon, IEvolvable
    {
        private const int EvolveAtLevel = 32;

        public Ivysaur(List<Attack> attacks, int currentLevel)
            : base("Ivysaur", currentLevel, attacks)
        {
        }

        public override void Speak()
        {
            Console.WriteLine($"{Name} says: Ivy ivy!");
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
            Console.WriteLine($"Now it's a Venusaur at level {Level}");
            return new Venusaur(Attacks, Level);
        }
    }

}