using System;
using Strategy_Pattern.Ducks;
using Strategy_Pattern.Ducks.Abstractions;

namespace Strategy_Pattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Duck mallard = new MallardDuck();
            mallard.PerformFly();
            mallard.PerformQuack();
            
            Console.WriteLine("-------------------------");

            Duck model = new ModelDuck();
            model.PerformFly();
            model.PerformQuack();

            Console.WriteLine("-------------------------");

            Duck rubber = new RubberDuck();
            rubber.PerformFly();
            rubber.PerformQuack();
        }
    }
}
