// See https://aka.ms/new-console-template for more information

using ObserverPattern;

var weatherData = new WeatherData();

var display1 = new StatisticsDisplay(weatherData);
var display2 = new ForecastDisplay(weatherData);
var display3 = new MobileDisplay(weatherData);

display1.Subcribe();
display2.Subcribe();
weatherData.MeasurementChange();


display1.UnSubcribe();
display3.Subcribe();

Console.WriteLine();
Console.WriteLine("Second time changed");
weatherData.MeasurementChange();



