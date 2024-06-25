namespace DesignPattern.Observer;

public class FoodCourt : IObserver
{
    public void Update(IObservable observable)
    {
        if (observable is WeatherStationObservable wsObservable)
        {
            Console.WriteLine($"FoodCourt : {wsObservable.Temperature}");
        }
    }
}
