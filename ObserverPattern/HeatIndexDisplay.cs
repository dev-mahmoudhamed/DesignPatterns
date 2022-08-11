namespace DesignPatterns.ObserverPattern
{
    public class HeatIndexDisplay : IDisplayElement, IObserver
    {
        double heatIndex;
        private WeatherData weatherData;
        public HeatIndexDisplay(WeatherData weatherData)
        {
            this.weatherData = weatherData;
            weatherData.registerObserver(this);
        }
        public void update(float temp, float humidity, float pressure)
        {
            this.heatIndex = heatIndex;
            display();
        }
        public void display()
        {
            Console.WriteLine("Heat Index is " + heatIndex);
        }
    }
}
