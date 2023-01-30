using SimpleFactoryPattern.Pizzas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleFactoryPattern.PizzaBusinesses
{
    public interface IPizzaFactory
    {
        Pizza CreatePizza(PizzaTypes pizzaType);
    }
}
