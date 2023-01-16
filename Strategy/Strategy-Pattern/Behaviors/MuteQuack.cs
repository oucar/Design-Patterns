using System;
using Strategy_Pattern.Behaviors.Abstractions;

namespace Strategy_Pattern.Behaviors
{
    public class MuteQuack : IQuackBehavior
    {
        public void Quack()
        {
            Console.WriteLine("Silence...");
        }
    }
}
