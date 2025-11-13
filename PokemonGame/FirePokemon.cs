namespace PokemonGame
{
    internal class FirePokemon : Pokemon
    {
        protected FirePokemon(string name, int level, List<Attack> attacks)
            : base(name, level, ElementType.Fire, attacks)
        {
        }
    }
}
