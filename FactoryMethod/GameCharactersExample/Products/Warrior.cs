namespace FactoryMethod.GameCharactersExample.Products
{
    internal class Warrior : ICharacter
    {
        public string? Name { get; set; }
        
        public int Health { get; set; }

        public Warrior(string? name, int health)
        {
            Name = name;
            Health = health;
        }

        public string Attack()
            => "Warrior attacked";

        public string Defend()
            => "Warrior defended";

        public string UseSpecialAbility()
            => "Warrior used special ability";
    }
}
