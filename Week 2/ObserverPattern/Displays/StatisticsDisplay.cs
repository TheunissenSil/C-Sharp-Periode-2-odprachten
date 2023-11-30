using ObserverPattern.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern.Displays
{
    internal class StatisticsDisplay : Observer, DisplayElement
    {
        private float temperature;
        private float sumTemperature = 0;
        private float maxTemp = float.MinValue; 
        private float minTemp = float.MaxValue; 
        private int countUpdated = 0;
        private Subject weatherData;

        public StatisticsDisplay(Subject weatherData)
        {
            this.weatherData = weatherData;
            weatherData.RegisterObserver(this); 
        }

        public void Update(float temp, float humidity, float pressure)
        {
            // Set the correct fields with the relevant parameters
            this.temperature = temp;

            // Update statistics
            sumTemperature += temp;
            maxTemp = Math.Max(maxTemp, temp);
            minTemp = Math.Min(minTemp, temp);

            countUpdated++;

            Display();
        }

        public void Display()
        {
            // Print the average, maximum, and minimum temperature.
            float averageTemp = sumTemperature / countUpdated;
            Console.WriteLine($"Gemiddelde temperatuur: {averageTemp}°C");
            Console.WriteLine($"Maximale temperatuur: {maxTemp}°C");
            Console.WriteLine($"Minimale temperatuur: {minTemp}°C");
        }
    }
}
