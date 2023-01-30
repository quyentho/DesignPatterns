using FactoryMethodPattern.Pizzas;
using FactoryMethodPattern.Pizzas.Vietnamese;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodPattern.PizzaFactories
{
    public class VietnamesePizzaFactory : PizzaFactory
    {
        public override Pizza CreatePizza(PizzaTypes pizzaType)
        {
            switch (pizzaType)
            {
                case PizzaTypes.CheesePizza:
                    return new VietnameseCheesePizza();
                case PizzaTypes.NoodlePizza:
                    return new VietnameseNoodlePizza();
                case PizzaTypes.VeggiePizza:
                    return new VietnameseVeggiePizza();
                default:
                    return null;
            };
        }
    }
}
