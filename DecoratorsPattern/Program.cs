// See https://aka.ms/new-console-template for more information

using DecoratorsPattern.Beverages;
using DecoratorsPattern.Sizes;
using DecoratorsPattern.Toppings;

IBeverage coffee = new Coffee();
coffee = new Bubble(coffee);
coffee = new Mocha(coffee);

Console.WriteLine(coffee.GetDescription());
Console.WriteLine($"Price: {coffee.Cost().ToString()}");

IBeverage blackTea = new BlackTea();
blackTea = new Berry(blackTea);
blackTea = new Berry(blackTea);
blackTea = new Mocha(blackTea);
blackTea = new Large(blackTea);


Console.WriteLine(blackTea.GetDescription());
Console.WriteLine($"Price: {blackTea.Cost().ToString()}");

