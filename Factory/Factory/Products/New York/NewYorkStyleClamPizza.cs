using Factory.Products.Abstractions;

namespace Factory.Products.New_York
{
    public class NewYorkStyleClamPizza : Pizza
    {
        public NewYorkStyleClamPizza()
        {
            Name = "NY Style Clam Pizza";
            Dough = "Thin Crust Dough";
            Sauce = "Marinara Sauce";

            Toppings.Add("Grated Reggiano Cheese");
            Toppings.Add("Fresh Clams from Long Island Sound");
        }
    }
}
