using SimpleFactoryPattern.PizzaBusinesses;
using SimpleFactoryPattern.Pizzas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleFactoryPattern
{
    // we now can have multiple type of pizza factory by implement IPizzaFactory
    public class SimplePizzaFactory : IPizzaFactory
    {
        // if we use static factory, we will loose the ability to inherite and modify this method
        public Pizza CreatePizza(PizzaTypes pizzaType)
        {
            Pizza pizza = null;
            switch (pizzaType)
            {
                case PizzaTypes.CheesePizza:
                    pizza = new CheesePizza();
                    break;
                case PizzaTypes.NoodlePizza:

                    pizza = new NoodlePizza();
                    break;
                case PizzaTypes.VeggiePizza:
                    pizza = new VeggiePizza();
                    break;
            };

            return pizza;
        }
    }
}
