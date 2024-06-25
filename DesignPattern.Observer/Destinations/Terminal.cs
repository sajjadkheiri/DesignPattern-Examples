namespace DesignPattern.Observer;

public class Terminal : IObserver
{
    public void Update(IObservable observable)
    {
        if (observable is WeatherStationObservable wsObservable)
        {
            Console.WriteLine($"Terminal : {wsObservable.Temperature}");
        }
    }
}
