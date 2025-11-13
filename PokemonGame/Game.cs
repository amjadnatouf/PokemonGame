
namespace PokemonGame
{
    internal class Game
    {
        public Game()
        {
            InitializeAttacks();
        }

        private void InitializeAttacks()
        {
            // Fire attacks
            Attack flamethrower = new Attack("Flamethrower", ElementType.Fire, 12);
            Attack ember = new Attack("Ember", ElementType.Fire, 6);

            // Water attacks
            Attack watergun = new Attack("Water Gun", ElementType.Water, 8);
            Attack hydropump = new Attack("Hydro Pump", ElementType.Water, 15);

            // Grass attacks
            Attack vinewhip = new Attack("Vine Whip", ElementType.Grass, 7);
            Attack razorleaf = new Attack("Razor Leaf", ElementType.Grass, 11);
        }

        internal void start()
        {
            throw new NotImplementedException();
        }
    }
}