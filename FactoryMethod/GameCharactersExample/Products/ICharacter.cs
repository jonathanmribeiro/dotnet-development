namespace FactoryMethod.GameCharactersExample.Products
{
    internal interface ICharacter
    {
        string? Name { get; set; }
        int Health { get; set; }

        string Attack();
        string Defend();
        string UseSpecialAbility();
    }
}
