using FactoryMethod.BaseExample.Products;

namespace FactoryMethod.BaseExample.Creators
{
    internal class ConcreteCreator2 : AbstractCreator
    {
        public override IProduct FactoryMethod()
            => new ConcreteProduct2();
    }
}
