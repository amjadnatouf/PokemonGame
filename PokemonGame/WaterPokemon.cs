
namespace PokemonGame
{
    internal class WaterPokemon : Pokemon
    {
        protected WaterPokemon(string name, int level, List<Attack> attacks)
            : base(name, level, ElementType.Water, attacks)
        {
        }
    }
}
