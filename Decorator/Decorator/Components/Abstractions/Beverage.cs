using System;

namespace Decorator.Components
{
    /// <summary>
    /// Beverage is an abstract class  with GetDescription() and Cost() methods.
    /// </summary>
    public abstract class Beverage
    {
        // Virtual methods have an implementation and provide the derived classes with the option of overriding it.
        public virtual string Description { get; protected set; } = "Unknown Beverage.";

        // Abstract methods do not provide an implementation and force the derived classes to override the method.
        public abstract double Cost();
    }
}
