
namespace PokemonGame
{
    internal class Charmeleon : FirePokemon, IEvolvable
    {
        private const int EvolveAtLevel = 36;

        public Charmeleon(List<Attack> attacks, int currentLevel)
        : base("Charmeleon", currentLevel, attacks)
        {
        }

        public override void Speak()
        {
            Console.WriteLine($"{Name} says: Char-meleon!");
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
            Console.WriteLine($"Now it's a Charmeleon at level {Level}");
            return new Charizard(Attacks, Level);
        }
    }
}