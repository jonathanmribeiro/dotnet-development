namespace FactoryMethod.GameCharactersExample.Products
{
    internal class Mage : ICharacter
    {
        public string? Name { get; set; }

        public int Health { get; set; }

        public Mage(string? name, int health)
        {
            Name = name;
            Health = health;
        }

        public string Attack()
            => "Mage attacked";

        public string Defend()
            => "Mage defended";

        public string UseSpecialAbility()
            => "Mage used special ability";
    }
}
