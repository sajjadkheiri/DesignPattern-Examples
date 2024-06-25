namespace DesignPattern.Observer;

public interface IObservable
{
    void Add(IObserver observer);
    void Remove(IObserver observer);
    void Notify();
}
