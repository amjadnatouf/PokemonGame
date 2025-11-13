
namespace PokemonGame
{
    internal class GrassPokemon : Pokemon
    {
        protected GrassPokemon(string name, int level, List<Attack> attacks)
            : base(name, level, ElementType.Grass, attacks)
        {
        }
    }
}
