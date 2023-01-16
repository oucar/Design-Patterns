using System;
using Strategy_Pattern.Behaviors;
using Strategy_Pattern.Ducks.Abstractions;

namespace Strategy_Pattern.Ducks
{
    public class RubberDuck : Duck
    {
        public RubberDuck()
        {
            FlyBehavior = new FlyNoWay();
            QuackBehavior = new Squeak();
        }

        public override void Display()
        {
            Console.WriteLine("I'm a rubber duckie");
        }
    }
}
