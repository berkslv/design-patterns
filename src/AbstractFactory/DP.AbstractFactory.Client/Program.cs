using DP.AbstractFactory.Source.Concrete;

namespace DP.AbstractFactory.Client
{
    public class Program
    {
        static void Main(string[] args)
        {
            var factory = new Factory();

            var product = factory.CreateProduct("MacBook Air M1");

            product.PrintName();
        }
    }
}