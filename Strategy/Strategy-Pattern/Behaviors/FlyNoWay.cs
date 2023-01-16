using Strategy_Pattern.Behaviors.Abstractions;
using System;

namespace Strategy_Pattern.Behaviors
{
    public class FlyNoWay : IFlyBehavior
    {
        public void Fly()
        {
            Console.WriteLine("I can't fly!");
        }
    }
}
