namespace DesignPatterns.ObserverPattern
{
    public interface IObserver
    {
        public void update(float temp, float humidity, float pressure);
    }
}