using System.Text;

namespace DesignPatterns
{
    public class Car
    {
        public string Make { get; set; }
        public string Color { get; set; }
        public string ManifactureDate { get; set; }

        public void Honk()
        {
            Console.WriteLine("Beep Beep!");
        }
    }

    public interface ICarBuilder
    {
        public ICarBuilder setMake(string make);

        public ICarBuilder setColor(string color);

        public ICarBuilder setManifactureDate(DateTime date);
    }

    public class CarBuilder : ICarBuilder
    {
        private Car _car = new Car();

        public ICarBuilder setMake(string make)
        {
            _car.Make = make;
            return this;
        }

        public ICarBuilder setColor(string color)
        {
            _car.Color = color;
            return this;
        }

        public ICarBuilder setManifactureDate(DateTime date)
        {
            _car.ManifactureDate = date.ToString("dd/MM/yyyy");
            return this;
        }

        public Car Build() => _car;

        public void CarDetails()
        {
            Console.WriteLine(
                $"Make: {_car.Make}, Color: {_car.Color}, Manifacture Date: {_car.ManifactureDate}"
            );
        }
    }
}
