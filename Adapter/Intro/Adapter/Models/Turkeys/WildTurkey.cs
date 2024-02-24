namespace Adapter.Models.Turkeys
{
    // Normally Ducks and Turkeys can't be used together as their interfaces are different.
    public class WildTurkey : ITurkey
    {
        public void Gobble()
        {
            Console.WriteLine("Gobble gobble");
        }

        public void Fly()
        {
            Console.WriteLine("I'm flying a short distance because I'm a Turkey lmao");
        }
    }
}
