namespace Command.Receivers
{
    public class GarageDoor
    {
        private readonly string _location;

        public GarageDoor(string location)
        {
            _location = location;
        }

        public void Up() => Console.WriteLine(_location + "Garage Door is Open");

        public void Down() => Console.WriteLine(_location + "Garage Door is Closed");

        public void Stop() => Console.WriteLine(_location + "Garage Door is Stopped");

        public void LightOn() => Console.WriteLine(_location + "Garage light is on");

        public void LightOff() => Console.WriteLine(_location + "Garage light is off");
    }
}
