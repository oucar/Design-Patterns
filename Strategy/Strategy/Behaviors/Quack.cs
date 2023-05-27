using System;
using Strategy_Pattern.Behaviors.Abstractions;

namespace Strategy_Pattern.Behaviors
{
    public class Quack : IQuackBehavior
    {
        void IQuackBehavior.Quack()
        {
            Console.WriteLine("Quack");
        }
    }
}
