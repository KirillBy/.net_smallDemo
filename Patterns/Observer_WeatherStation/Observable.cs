using System.Collections.Generic;

namespace Observer_WeatherStation
{
    public interface IObservable
    {
        public void AddSubscriber(IObserver observable);
        public void RemoveSubscriber(IObserver observable);
        public void NotifyAll(double temperature, double humidity, int pressure);
    }
    
    public class WeatherStation : IObservable
    {
        private double _temperature;
        private double _humidity;
        private int _pressure;
        
        private List<IObserver> _observers;

        public WeatherStation()
        {
            _observers = new List<IObserver>();
        }
        public void AddSubscriber(IObserver observer)
        {
            _observers.Add(observer);
        }

        public void RemoveSubscriber(IObserver observer)
        {
            var index = _observers.IndexOf(observer);
            if (index > 0)
            _observers.RemoveAt(index);
        }

        public void NotifyAll(double temperature, double humidity, int pressure)
        {
            foreach (var observer in _observers)
            {
                observer.Update(temperature, humidity, pressure);
            }
        }

        public void SetWeatherData(double temperature, double humidity, int pressure)
        {
            _temperature = temperature;
            _humidity = humidity;
            _pressure = pressure;
            NotifyAll(_temperature, _humidity, _pressure);
        }
    }
}