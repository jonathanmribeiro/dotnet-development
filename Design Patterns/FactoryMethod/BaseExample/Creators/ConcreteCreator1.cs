using FactoryMethod.BaseExample.Products;

namespace FactoryMethod.BaseExample.Creators
{
    internal class ConcreteCreator1 : AbstractCreator
    {
        public override IProduct FactoryMethod()
            => new ConcreteProduct1();
    }
}
