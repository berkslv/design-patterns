namespace DP.Builder.Source
{
    public class Burger
    {
        public string Size { get; set; }

        public bool Cheese { get; set; }

        public bool Lettuce { get; set; }

        public bool Tomato { get; set; }

        public Burger(
            string size,
            bool cheese = false,
            bool lettuce = false,
            bool tomato = false
        )
        {
            Size = size;
            Cheese = cheese;
            Lettuce = lettuce;
            Tomato = tomato;
        }

        public Burger(BurgerBuilder builder)
        {
            Size = builder.Size;
            Cheese = builder.Cheese;
            Lettuce = builder.Lettuce;
            Tomato = builder.Tomato;
        }


        public void PrintBurger()
        {
            Console.WriteLine(Size, Cheese, Lettuce, Tomato);
        }
    }
}
