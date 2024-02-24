using Adapter.Models.Ducks;
using Adapter.Models.Turkeys;

namespace Adapter.Adapters
{
    // Where IDuck is the target interface.
    // Target interface - Interface our client expects to see
    public class TurkeyAdapter : IDuck 
    {
        // Adaptee interface
        private readonly ITurkey _turkey;

        public TurkeyAdapter(ITurkey turkey)
        {
            _turkey = turkey;
        }

        // A Turkey doesn't quack - so we make it gobble here.
        public void Quack()
        {
            _turkey.Gobble();
        }

        public void Fly()
        {
            for (int i = 0; i < 5; i++)
            {
                _turkey.Fly();
            }
        }
    }
}
