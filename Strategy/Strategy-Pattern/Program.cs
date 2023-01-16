using System;
using Strategy_Pattern.Ducks;
using Strategy_Pattern.Ducks.Abstractions;

namespace Strategy_Pattern
{
    class Program
    {
        //
        static void Main(string[] args)
        {
            Duck mallard = new MallardDuck();
            mallard.PerformFly();
            mallard.PerformQuack();
        }
    }
}
