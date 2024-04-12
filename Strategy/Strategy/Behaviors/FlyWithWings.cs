using System;
using Strategy_Pattern.Behaviors.Abstractions;

namespace Strategy_Pattern.Behaviors
{
    public class FlyWithWings : IFlyBehavior
    {
        public void Fly()
        {
            Console.WriteLine("I'm flying!");
        }
    }
}
