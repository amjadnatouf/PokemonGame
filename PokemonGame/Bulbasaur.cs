namespace PokemonGame
{
    internal class Bulbasaur : GrassPokemon, IEvolvable
    {
        private const string EvolvedName = "Ivysaur";
        public Bulbasaur(List<Attack> attacks) : base("Bulbasaur", 1, attacks)
        {
        }

        public void Evolve()
        {
            Name = EvolvedName;
            Level += 10;
            Console.WriteLine($"Bulbasaur is evolving... Now it is a {Name} and its level is {Level}");
        }
    }
}
