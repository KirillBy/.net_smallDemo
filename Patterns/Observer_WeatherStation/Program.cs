using System;

namespace Observer_WeatherStation
{
    class Program
    {
        static void Main(string[] args)
        {
            WeatherStation weatherStation = new WeatherStation();
            StatisticDisplay statisticDisplay = new StatisticDisplay(weatherStation);
            HistoryDisplay historyDisplay = new HistoryDisplay(weatherStation);
            CurrentWeatherDisplay currentWeatherDisplay = new CurrentWeatherDisplay(weatherStation);
            weatherStation.SetWeatherData(25.5, 80.5, 90);
            historyDisplay.UnSubscribe();
            weatherStation.SetWeatherData(28.9, 83.3, 75);
            historyDisplay.UnSubscribe();
        }
    }
}
