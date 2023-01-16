using Strategy_Pattern.Behaviors.Abstractions;
using System;

namespace Strategy_Pattern.Behaviors
{
    public class FlyRocketPowered : IFlyBehavior
    {
        public void Fly()
        {
            Console.WriteLine("I'm flying with a rocket!");
        }
    }
}
