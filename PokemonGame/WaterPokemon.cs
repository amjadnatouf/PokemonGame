
namespace PokemonGame
{
    internal class WaterPokemon : Pokemon
    {
        public WaterPokemon(string name, int level, ElementType type, List<Attack> attacks)
            : base(name, level, ElementType.Water, attacks)
        {
        }
    }
}
