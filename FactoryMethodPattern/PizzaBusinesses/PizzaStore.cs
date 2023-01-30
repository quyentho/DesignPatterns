using FactoryMethodPattern.PizzaFactories;
using FactoryMethodPattern.Pizzas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodPattern.PizzaBusinesses
{
    public class PizzaStore
    {
        private readonly PizzaFactory _pizzaFactory;

        public PizzaStore(PizzaFactory pizzaFactory)
        {
            this._pizzaFactory = pizzaFactory;
        }

        public void GetPizza(PizzaTypes type)
        {
            _pizzaFactory.OrderPizza(type);
        }
    }
}
