using FactoryMethod.GameCharactersExample.Products;

namespace FactoryMethod.GameCharactersExample.Creators
{
    internal class WarriorFactory : CharacterFactory
    {
        public override ICharacter CreateCharacter()
            => new Warrior("Warrior", 100);
    }
}
