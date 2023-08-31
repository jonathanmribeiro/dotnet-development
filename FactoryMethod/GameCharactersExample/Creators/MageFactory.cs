using FactoryMethod.GameCharactersExample.Products;

namespace FactoryMethod.GameCharactersExample.Creators
{
    internal class MageFactory : CharacterFactory
    {
        public override ICharacter CreateCharacter()
            => new Warrior("Mage", 50);
    }
}
