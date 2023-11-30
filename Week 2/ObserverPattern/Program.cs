using ObserverPattern.Displays;

namespace ObserverPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            WeatherData weatherData = new WeatherData();

            CurrentConditionDisplay currentConditionDisplay = new CurrentConditionDisplay(weatherData);
            ForecastDisplay forecastDisplay = new ForecastDisplay(weatherData);
            StatisticsDisplay statisticsDisplay = new StatisticsDisplay(weatherData);

            // Update weather conditions
            Console.WriteLine("Initial weather conditions:");
            weatherData.SetMeasurements(28, 65, 30.4f);

            // Unsubscribe an observer
            Console.WriteLine("\nUnsubscribing CurrentConditionDisplay");
            weatherData.RemoveObserver(currentConditionDisplay);

            // Update weather conditions 
            Console.WriteLine("\nUpdated weather conditions after unsubscribing:");
            weatherData.SetMeasurements(29, 70, 29.2f);

            Console.ReadLine();
        }
    }
}