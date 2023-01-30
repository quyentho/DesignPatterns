// See https://aka.ms/new-console-template for more information


public class WeatherData: ISubject
{
    private List<IObserver> _observers = new List<IObserver>();
    private Random _random = new Random();

    public WeatherData()
    {
    }
    public void RegisterObserver(IObserver observer)
    {
        _observers.Add(observer);
    }

    private int GetHumidity()
    {
        return _random.Next();
    }
    private int GetTemperature()
    {
        return _random.Next();
    }
    private int GetPressure()
    {
        return _random.Next();
    }

    public void MeasurementChange()
    {
        var humidity = GetHumidity();
        var pressure = GetPressure();
        var temperature = GetTemperature();
        foreach (var observer in _observers)
        {
            observer.Update(humidity, pressure, temperature);
        }
    }

    public void UnRegisterObserver(IObserver IObserver)
    {
        _observers.Remove(IObserver);
    }
}
