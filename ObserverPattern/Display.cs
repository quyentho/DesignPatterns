// See https://aka.ms/new-console-template for more information
public abstract class Display : IDisplay
{
    public Display(ISubject weatherData)
    {
        this._weatherData = weatherData;
    }
    public void Subcribe()
    {
        _weatherData.RegisterObserver(this);
    }
    
    public void UnSubcribe()
    {
        _weatherData.RemoveObserver(this);
    }

    private int humidity;
    public int pressure;
    public int temperature;
    private readonly ISubject _weatherData;

    public void Update(int newHumidity, int newPressure, int newTemp)
    {
        humidity = newHumidity;
        pressure = newPressure;
        temperature = newTemp;
        DisplayData();
    }

    public virtual void DisplayData()
    {
        Console.WriteLine($"Humidity: {humidity}, Pressure: {pressure}, Temperature: {temperature}");
    }
}
