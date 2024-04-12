using System;
using Strategy_Pattern.Behaviors;
using Strategy_Pattern.Ducks.Abstractions;

namespace Strategy_Pattern.Ducks
{
    public class MallardDuck : Duck
    {

        // constructor
        // MallardDuck can quack and fly as normal
        public MallardDuck()
        {
            QuackBehavior = new Quack();
            FlyBehavior = new FlyWithWings();
        }

        public override void Display()
        {
            Console.WriteLine("I am a real Mallard Duck!");
        }
    }
}
