using Decorator.Components;

namespace Decorator.Decorators.Abstractions
{
    /// <summary>
    /// Abstract Decorator
    /// </summary>
    public abstract class CondimentDecorator : Beverage
    {
        public abstract override string Description { get; }
    }
}
