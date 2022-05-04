using DP.AbstractFactory.Source.Abstract;

namespace DP.AbstractFactory.Source.Concrete
{
    public class Factory : IFactory
    {
        public Product CreateProduct(string name)
        {
            return new Product(name);
        }
    }
}