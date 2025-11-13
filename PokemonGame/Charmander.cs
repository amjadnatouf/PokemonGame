namespace PokemonGame
{
    internal class Charmander : FirePokemon, IEvolvable
    {
        private const string EvolvedName = "Charmeleon";

        public Charmander(List<Attack> attacks) : base("Charmander", 1, attacks)
        {
        }

        public void Evolve()
        {
            Name = EvolvedName;
            Level += 10;
            Console.WriteLine($"Charmander is evolving... Now it is a {Name} and its level is {Level}");
        }
    }
}
