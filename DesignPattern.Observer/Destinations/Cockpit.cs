namespace DesignPattern.Observer;

public class Cockpit : IObserver
{
    public void Update(IObservable observable)
    {
        if (observable is WeatherStationObservable wsObservable)
        {
            Console.WriteLine($"Cockpit : {wsObservable.Temperature}");
        }
    }
}
