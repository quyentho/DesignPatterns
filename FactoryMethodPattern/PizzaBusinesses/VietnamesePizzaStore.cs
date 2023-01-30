using FactoryMethodPattern.PizzaFactories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodPattern.PizzaBusinesses
{
    public class VietnamesePizzaStore : PizzaStore
    {
        public VietnamesePizzaStore(VietnamesePizzaFactory pizzaFactory) : base(pizzaFactory)
        {
            Console.WriteLine("Vietnamese");
        }
    }
}
