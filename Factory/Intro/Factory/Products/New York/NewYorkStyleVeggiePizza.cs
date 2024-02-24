using Factory.Products.Abstractions;

namespace Factory.Products.New_York
{
    public class NewYorkStyleVeggiePizza : Pizza
    {
        public NewYorkStyleVeggiePizza()
        {
            Name = "NY Style Veggie Pizza";
            Dough = "Thin Crust Dough";
            Sauce = "Marinara Sauce";

            Toppings.Add("Grated Reggiano Cheese");
            Toppings.Add("Garlic");
            Toppings.Add("Onion");
            Toppings.Add("Mushrooms");
            Toppings.Add("Red Pepper");
        }

        public override void Cut()
        {
            Console.WriteLine("Cutting the pizza into square slices");
        }
    }
}