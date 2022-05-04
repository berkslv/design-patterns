using DP.Builder.Source;

namespace DP.Builder.Client
{
    public class Program
    {
        static void Main(string[] args)
        {
            var burger = new BurgerBuilder("Large")
                                            .AddCheese()
                                            .AddLettuce()
                                            .AddTomato()
                                            .Build();

            burger.PrintBurger();

        }
    }
}