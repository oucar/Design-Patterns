using System;
using Factory.FactoryMethods.Abstractions;
using Factory.FactoryMethods;
using Factory.Products.Abstractions;

namespace PizzaStoreFactoryMethod
{
    public class Program
    {
        public static void Main(string[] args)
        {
            PizzaStore nyStore = new NewYorkPizzaStore();
            PizzaStore chicagoStore = new ChicagoPizzaStore();

            // NY
            Pizza pizza = nyStore.OrderPizza("cheese");
            Console.WriteLine("Ethan ordered a " + pizza + "\n");

            pizza = chicagoStore.OrderPizza("cheese");
            Console.WriteLine("Joel ordered a " + pizza + "\n");

            pizza = nyStore.OrderPizza("clam");
            Console.WriteLine("Ethan ordered a " + pizza + "\n");

            // CHICAGO
            pizza = chicagoStore.OrderPizza("clam");
            Console.WriteLine("Joel ordered a " + pizza + "\n");

            pizza = nyStore.OrderPizza("pepperoni");
            Console.WriteLine("Ethan ordered a " + pizza + "\n");

            pizza = chicagoStore.OrderPizza("pepperoni");
            Console.WriteLine("Joel ordered a " + pizza + "\n");

            pizza = nyStore.OrderPizza("veggie");
            Console.WriteLine("Ethan ordered a " + pizza + "\n");

            pizza = chicagoStore.OrderPizza("veggie");
            Console.WriteLine("Joel ordered a " + pizza + "\n");
        }
    }
}