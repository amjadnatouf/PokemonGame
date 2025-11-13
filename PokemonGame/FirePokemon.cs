namespace PokemonGame
{
    internal class FirePokemon : Pokemon
    {
        public FirePokemon(string name, int level, ElementType type, List<Attack> attacks)
            : base(name, level, ElementType.Fire, attacks)
        {
        }
    }
}
