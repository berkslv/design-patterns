namespace DP.Builder.Source
{
    public class BurgerBuilder
    {
        public string Size { get; set; }

        public bool Cheese { get; set; }

        public bool Lettuce { get; set; }

        public bool Tomato { get; set; }

        public BurgerBuilder(string size)
        {
            Size = size;
        }

        public BurgerBuilder AddCheese()
        {
            Cheese = true;
            return this;
        }

        public BurgerBuilder AddLettuce()
        {
            Lettuce = true;
            return this;
        }

        public BurgerBuilder AddTomato()
        {
            Tomato = true;
            return this;
        }

        public Burger Build()
        {
            return new Burger(this);
        }
    }
}