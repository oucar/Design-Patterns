namespace Observer.Observers.Abstractions
{
    public interface IObserver
    {
        // State values the Observers get from the Subject
        // when a weather measurement changes.
        void Update(double temp, double humidity, double pressure);
    }
}
