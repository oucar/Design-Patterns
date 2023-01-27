using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Observer.Observers.Abstractions;
using Observer.Subjects;
using Observer.Subjects.Abstractions;

namespace Observer.Observers
{
    // Implements the Observer so that it can get changes from the WeatherData object
    // Implements DisplayElement because our API is going to require all display elements to implement this interface
    public class CurrentConditionsDisplay : IObserver, IDisplayElement
    {
        private double _humidity;
        private double _temperature;
        private ISubject _weatherData;

        public CurrentConditionsDisplay(WeatherData weatherData)
        {
            this._weatherData = weatherData;
            weatherData.RegisterObserver(this);
        }

        public void Display()
        {
            Console.WriteLine("Current conditions: " + _temperature + "F degrees and " + _humidity + "% humidity");
        }

        public void Update(double temp, double humidity, double pressure)
        {
            _temperature = temp;
            _humidity = humidity;
            Display();
        }
    }
}
