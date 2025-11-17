
namespace PokemonGame
{
    internal class Squirtle : WaterPokemon
    {
        private const int EvolveAtLevel = 16;
        public Squirtle(List<Attack> attacks) : base("Squirtle", 1, attacks)
        {
        }

        public override void Speak()
        {
            Console.WriteLine($"{Name} says: Squirt squirt!");
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
            Console.WriteLine($"Now it's a Wartortle at level {Level}");
            return new Wartortle(Attacks, Level);
        }
    }
}
