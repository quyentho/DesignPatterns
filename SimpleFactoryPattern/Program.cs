// See https://aka.ms/new-console-template for more information


using SimpleFactoryPattern;
using SimpleFactoryPattern.PizzaBusinesses;

PizzaStore pizzaStore = new PizzaStore(new SimplePizzaFactory());
pizzaStore.OrderPizza(PizzaTypes.CheesePizza);

Console.WriteLine();
Console.WriteLine("order second pizza");

pizzaStore.OrderPizza(PizzaTypes.VeggiePizza);
