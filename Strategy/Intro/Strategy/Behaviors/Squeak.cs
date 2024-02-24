using Strategy_Pattern.Behaviors.Abstractions;
using System;

namespace Strategy_Pattern.Behaviors
{
    public class Squeak : IQuackBehavior

    {
        public void Quack()
        {
            Console.WriteLine("Squeak??");
        }
    }
}
