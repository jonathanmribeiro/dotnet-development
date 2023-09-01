using FactoryMethod.GameCharactersExample.Products;

namespace FactoryMethod.GameCharactersExample.Creators
{
    internal class ArcherFactory : CharacterFactory
    {
        public override ICharacter CreateCharacter()
            => new Warrior("Archer", 70);
    }
}
