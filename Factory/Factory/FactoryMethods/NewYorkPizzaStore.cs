using Factory.FactoryMethods.Abstractions;
using Factory.Products.Abstractions;
using Factory.Products.New_York;

namespace Factory.FactoryMethods
{
    public class NewYorkPizzaStore : PizzaStore
    {
        protected override Pizza CreatePizza(string item)
        {
            Pizza pizza = null;

            switch (item)
            {
                case "cheese":
                    pizza = new NewYorkStyleCheesePizza();
                    break;
                case "veggie":
                    pizza = new NewYorkStyleVeggiePizza();
                    break;
                case "clam":
                    pizza = new NewYorkStyleClamPizza();
                    break;
                case "pepperoni":
                    pizza = new NewYorkStylePepperoniPizza();
                    break;
            }

            return pizza;
        }
    }
}
