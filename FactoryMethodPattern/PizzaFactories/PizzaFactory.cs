using FactoryMethodPattern.Pizzas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodPattern.PizzaFactories
{
    public abstract class PizzaFactory
    {
        // the whole point is have an abstract method for children classes
        // to decide how to implement the creation of family of classes
        // eg: (VietnamesePizza and AmericaPizza)
        public abstract Pizza CreatePizza(PizzaTypes pizzaType);
        public void OrderPizza(PizzaTypes pizzaType)
        {
            var pizza = CreatePizza(pizzaType);
            pizza.Prepare();
            pizza.Bake();
            pizza.Cut();
            pizza.Box();
        }

    }
}
