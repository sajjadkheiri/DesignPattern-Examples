namespace DesignPattern.Observer;

public class WeatherStationObservable : IObservable
{
    public decimal Temperature { get; private set; }
    private readonly List<IObserver> _observers;

    public WeatherStationObservable()
    {
        _observers = new List<IObserver>();
    }

    public void Add(IObserver observer)
    {
        _observers.Add(observer);
    }

    public void SetTemperature(decimal temper)
    {
        Temperature = temper;
        Notify();
    }

    public void Notify()
    {
        foreach (var observer in _observers)
        {
            observer.Update(this);
        }
    }

    public void Remove(IObserver observer)
    {
        _observers.Remove(observer);
    }
}
