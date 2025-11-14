namespace PokemonGame
{
    internal class LegendaryAttack : Attack
    {
        public LegendaryAttack(Attack baseAttack)
            : base("Legendary" + baseAttack.Name, baseAttack.Type, baseAttack.BasePower * 2)
        {
        }

        public override void Use(int level)
        {
            int totalPower = BasePower + level * 2;
            Console.WriteLine($"{Name} unleashes its potential with total power {totalPower}!");
        }
    }
}
