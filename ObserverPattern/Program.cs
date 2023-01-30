// See https://aka.ms/new-console-template for more information

using ObserverPattern;

var weatherData = new WeatherData();

var display1 = new StatisticsDisplay();
var display2 = new ForecastDisplay();
var display3 = new MobileDisplay();

weatherData.RegisterObserver(display1);
weatherData.RegisterObserver(display2);
weatherData.MeasurementChange();


weatherData.UnRegisterObserver(display1);
weatherData.RegisterObserver(display3);

Console.WriteLine();
Console.WriteLine("Second time changed");
weatherData.MeasurementChange();



