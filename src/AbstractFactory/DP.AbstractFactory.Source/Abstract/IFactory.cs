using DP.AbstractFactory.Source.Concrete;

namespace DP.AbstractFactory.Source.Abstract
{
    public interface IFactory
    {
        Product CreateProduct(string name);
    }
}