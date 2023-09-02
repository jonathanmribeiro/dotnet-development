using Builder.BaseExample.Interface;

namespace Builder.BaseExample
{
    internal class ConcreteBuilder : IBuilder
    {
        private Product _product = new();

        public ConcreteBuilder()
            => Reset();

        public void Reset()
            => _product = new Product();

        public void BuildPartA()
            => _product.Add("Part A");

        public void BuildPartB()
            => _product.Add("Part B");

        public void BuildPartC()
            => _product.Add("Part C");

        public Product GetProduct()
        {
            Product result = _product;
            Reset();
            return result;
        }
    }
}
