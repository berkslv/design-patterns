namespace DP.AbstractFactory.Source.Concrete
{
    public class Product
    {
        public string Name { get; private set; }

        public Product(string name)
        {
            Name = name;
        }

        public void PrintName()
        {
            Console.WriteLine(Name);
        }
    }
}