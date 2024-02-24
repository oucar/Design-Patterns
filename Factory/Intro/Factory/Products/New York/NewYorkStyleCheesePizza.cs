using Factory.Products.Abstractions;

namespace Factory.Products.New_York
{
    public class NewYorkStyleCheesePizza : Pizza
    {
        public NewYorkStyleCheesePizza()
        {
            Name = "NY Style Sauce and Cheese Pizza";
            Dough = "Thin Crust Dough";
            Sauce = "Marinara Sauce";

            Toppings.Add("Grated Reggiano Cheese");
        }
    }
}
