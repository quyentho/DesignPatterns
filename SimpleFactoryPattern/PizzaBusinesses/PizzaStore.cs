using SimpleFactoryPattern.Pizzas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleFactoryPattern.PizzaBusinesses
{
    public class PizzaStore
    {
        private readonly IPizzaFactory _simplePizzaFactory;

        public PizzaStore(IPizzaFactory simplePizzaFactory)
        {
            _simplePizzaFactory = simplePizzaFactory;
        }
        public virtual Pizza OrderPizza(PizzaTypes pizzaType)
        {
            Pizza pizza = null;


            #region Before use factory pattern
            //switch (pizzaType)
            //{
            //    case PizzaTypes.CheesePizza:
            //        pizza = new CheesePizza();
            //        break;
            //    case PizzaTypes.NoodlePizza:

            //        pizza = new NoodlePizza();
            //        break;
            //    case PizzaTypes.VeggiePizza:
            //        pizza = new VeggiePizza();
            //        break;
            //};
            #endregion

            // factory pattern
            // now we have the ability to use the same CreatePizza in multiple classes
            pizza = _simplePizzaFactory.CreatePizza(pizzaType);

            pizza.Prepare();
            pizza.Bake();
            pizza.Cut();
            pizza.Box();
            return pizza;
        }
    }
}
