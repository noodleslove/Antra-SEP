namespace DesignPatterns.Builder
{
    public class ConcreteBuilder : IBuilder
    {
        private Product _product = new Product();

        public ConcreteBuilder()
        {
            Reset();
        }

        public void Reset()
        {
            _product = new Product();
        }

        public void BuildPartA()
        {
            _product.Add("PartA");
        }

        public void BuildPartB()
        {
            _product.Add("PartB");
        }

        public void BuildPartC()
        {
            _product.Add("PartC");
        }

        public Product GetProduct()
        {
            Product result = _product;
            Reset();
            return result;
        }
    }
}