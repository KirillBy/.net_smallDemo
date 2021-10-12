using System;

namespace Observer_WeatherStation
{
    public interface IObserver
    {
        public void Update(double temperature, double humidity, int pressure);
    }

    public interface IDisplayScreen
    {
        public void Display();
    }
    
    public class StatisticDisplay: IObserver, IDisplayScreen
    {
        private double _temperature;
        private double _humidity;
        private int _pressure;
        private IObservable _observable;

        public StatisticDisplay(IObservable observable)
        {
            this._observable = observable;
            _observable.AddSubscriber(this);
        }

        public void UnSubscribe()
        {
            _observable?.RemoveSubscriber(observable: this);
            _observable = null;
        }
        
        public void Update(double temperature, double humidity, int pressure)
        {
            this._temperature = temperature;
            this._humidity = humidity;
            this._pressure = pressure;
            Display();
        }

        public void Display()
        {
            Console.WriteLine($"Statistic Display: temperature {_temperature}, humidity {_humidity}, pressure {_pressure}");
        }
    }
    
    
    public class HistoryDisplay: IObserver, IDisplayScreen
    {
        private double _temperature;
        private double _humidity;
        private int _pressure;
        private IObservable _observable;

        public HistoryDisplay(IObservable observable)
        {
            this._observable = observable;
            _observable.AddSubscriber(this);
        }

        public void UnSubscribe()
        {
            _observable?.RemoveSubscriber(observable: this);
            _observable = null;
        }
        
        public void Update(double temperature, double humidity, int pressure)
        {
            this._temperature = temperature;
            this._humidity = humidity;
            this._pressure = pressure;
            Display();
        }

        public void Display()
        {
            Console.WriteLine($"History Display: temperature {_temperature}, humidity {_humidity}, pressure {_pressure}");
        }
    }
    
    public class CurrentWeatherDisplay: IObserver, IDisplayScreen
    {
        private double _temperature;
        private double _humidity;
        private int _pressure;
        private IObservable _observable;

        public CurrentWeatherDisplay(IObservable observable)
        {
            this._observable = observable;
            _observable.AddSubscriber(this);
        }

        public void UnSubscribe()
        {
            _observable?.RemoveSubscriber(observable: this);
            _observable = null;
        }
        
        public void Update(double temperature, double humidity, int pressure)
        {
            this._temperature = temperature;
            this._humidity = humidity;
            this._pressure = pressure;
            Display();
        }

        public void Display()
        {
            Console.WriteLine($"Current Weather Display: temperature {_temperature}, humidity {_humidity}, pressure {_pressure}");
        }
    }
}