using FactoryMethodPattern.Pizzas;
using FactoryMethodPattern.Pizzas.AmericaStyles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodPattern.PizzaFactories
{
    public class AmericaPizzaFactory : PizzaFactory
    {
        public override Pizza CreatePizza(PizzaTypes pizzaType)
        {
            switch (pizzaType)
            {
                case PizzaTypes.CheesePizza:
                    return new AmericaCheesePizza();
                case PizzaTypes.NoodlePizza:
                    return new AmericaNoodlePizza();
                case PizzaTypes.VeggiePizza:
                    return new AmericaVeggiePizza();
                default:
                    return null;
            };

        }
    }
}
