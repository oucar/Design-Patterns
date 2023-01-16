using Strategy_Pattern.Behaviors.Abstractions;
using System;

namespace Strategy_Pattern.Ducks.Abstractions
{
    public abstract class Duck
    {
        // References to the behaviors
        protected IFlyBehavior FlyBehavior { get; set; }
        protected IQuackBehavior QuackBehavior { get; set; }

        protected Duck(){}

        public abstract void Display();

        public void PerformFly()
        {
            FlyBehavior.Fly();
        }

        public void PerformQuack()
        {
            QuackBehavior.Quack();
        }

        public void Swim()
        {
            Console.WriteLine("All ducks float, even decoys!");

        }



    }
}
