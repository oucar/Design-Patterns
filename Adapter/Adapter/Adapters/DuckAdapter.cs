using Adapter.Models.Ducks;
using Adapter.Models.Turkeys;

namespace Adapter.Adapters
{
    // Target interface - Interface our client expects to see
    public class DuckAdapter : ITurkey 
    {
        // Adaptee interface
        private readonly IDuck _duck;
        private readonly Random _random;

        public DuckAdapter(IDuck duck)
        {
            _duck = duck;
            _random = new Random();
        }

        // A Duck normally doesn't gobble. So we make it quack here.
        public void Gobble()
        {
            _duck.Quack();
        }

        public void Fly()
        {
            if (_random.Next(5) == 0)
            {
                _duck.Fly();
            }
        }
    }
}
