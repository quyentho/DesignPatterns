// See https://aka.ms/new-console-template for more information


using FactoryMethodPattern;
using FactoryMethodPattern.PizzaBusinesses;
using FactoryMethodPattern.PizzaFactories;

PizzaStore pizzaStore = new AmericaPizzaStore(new AmericaPizzaFactory());

pizzaStore.GetPizza(PizzaTypes.NoodlePizza);

pizzaStore = new VietnamesePizzaStore(new VietnamesePizzaFactory());

pizzaStore.GetPizza(PizzaTypes.CheesePizza);
