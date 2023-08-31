namespace FactoryMethod.GameCharactersExample.Products
{
    internal class Archer : ICharacter
    {
        public string? Name { get; set; }

        public int Health { get; set; }

        public Archer(string? name, int health)
        {
            Name = name;
            Health = health;
        }

        public string Attack()
            => "Archer attacked";

        public string Defend()
            => "Archer defended";

        public string UseSpecialAbility()
            => "Archer used special ability";
    }
}
