namespace PokemonGame
{
    internal class LegendaryAttack : Attack
    {
        public LegendaryAttack(Attack baseAttack)
            : base(baseAttack.Name, baseAttack.Type, baseAttack.BasePower)
        {
        }

        public override void Use(int level)
        {
            int totalPower = BasePower + level * 2;
            Console.WriteLine($"{Name} unleashes its potential with total power {totalPower}!");
        }
    }
}
