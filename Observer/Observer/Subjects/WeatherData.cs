using System.Collections.Generic;
using Observer.Observers.Abstractions;
using Observer.Subjects.Abstractions;


namespace Observer.Subjects
{

    // WeatherData implements ISubject interface
    // It is being used to update the displays
    public class WeatherData : ISubject
    {
        // array to hold the observers
        private readonly List<IObserver> _observers;
        private double _temperature;
        private double _humidity;
        private double _pressure;

        // constructor
        public WeatherData()
        {
            // initialize the observer array
            _observers = new List<IObserver>();
        }

        public void MeasurementChanged()
        {
            NotifyObservers();
        }

        public void SetMeasurements(double temperature, double humidity, double pressure)
        {
            _temperature = temperature;
            _humidity = humidity;
            _pressure = pressure;
            MeasurementChanged();
        }

        public void RegisterObserver(IObserver o)
        {
            _observers.Add(o);
        }

        public void RemoveObserver(IObserver o)
        {
            _observers.Remove(o);
        }

        public void NotifyObservers()
        {
            foreach(var observer in _observers)
            {
                observer.Update(_temperature, _humidity, _pressure);
            }
        }


    }
}
