using System;
using Strategy_Pattern.Behaviors;
using Strategy_Pattern.Ducks.Abstractions;

namespace Strategy_Pattern.Ducks
{
    public class ModelDuck : Duck
    {

        public ModelDuck()
        {
            FlyBehavior = new FlyNoWay();
            QuackBehavior = new MuteQuack();
        }

        public override void Display()
        {
            Console.WriteLine("I'm a model duck");
        }
    }
}
