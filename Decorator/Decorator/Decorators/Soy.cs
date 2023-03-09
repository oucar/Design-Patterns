using Decorator.Components;
using Decorator.Decorators.Abstractions;

namespace Decorator.Decorators
{
    public class Soy : CondimentDecorator
    {
        private readonly Beverage _beverage;

        public Soy(Beverage beverage)
        {
            _beverage = beverage;
        }

        public override string Description => _beverage.Description + ", Soy";

        public override double Cost()
        {
            return .15 + _beverage.Cost();
        }

    }
}
