using FactoryMethod.GameCharactersExample.Products;

namespace FactoryMethod.GameCharactersExample.Creators
{
    internal abstract class CharacterFactory
    {
        public abstract ICharacter CreateCharacter();

        public ICharacter ObtainCharacter()
            => CreateCharacter();
    }
}
