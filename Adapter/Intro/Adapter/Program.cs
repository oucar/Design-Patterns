using Adapter.Adapters;
using Adapter.Models.Ducks;
using Adapter.Models.Turkeys;

namespace Adapter
{
    public class Program
    {
        public static void Main(string[] args)
        {
            MallardDuck duck = new MallardDuck();
            WildTurkey turkey = new WildTurkey();

            // Wrap the Turkey in a TurkeyAdapter, which makes it look like a Duck.
            IDuck turkeyAdapter = new TurkeyAdapter(turkey);

            Console.WriteLine("The Regular Turkey says...");
            turkey.Gobble();
            turkey.Fly();

            // TestDuck expects a Duck object
            Console.WriteLine("\nThe Duck says...");
            TestDuck(duck);

            // TestDuck expects a Duck object but we're passing a Turkey adapter here.
            // "Turns" Turkey into a Duck as it's an adapter.
            Console.WriteLine("\nThe TurkeyAdapter says...");
            TestDuck(turkeyAdapter);

            // Duck adapter - Turns a Duck into a Turkey
            ITurkey duckAdapter = new DuckAdapter(duck);

            Console.WriteLine("");
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("\nThe DuckAdapter says...");
                duckAdapter.Gobble();
                duckAdapter.Fly();
            }
        }

        public static void TestDuck(IDuck duck)
        {
            duck.Quack();
            duck.Fly();
        }
    }
}