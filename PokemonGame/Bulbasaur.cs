namespace PokemonGame
{
    internal class Bulbasaur : GrassPokemon, IEvolvable
    {
        private const int EvolveAtLevel = 16;

        public Bulbasaur(List<Attack> attacks) : base("Bulbasaur", 1, attacks)
        {
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

        public override void Speak()
        {
            Console.WriteLine($"{Name} says: Bulba bulba!");
        }

        public Pokemon Evolve()
        {
            Console.WriteLine($"Now it's a Ivysaur at level {Level}");
            return new Ivysaur(Attacks, Level);
        }
    }
}
