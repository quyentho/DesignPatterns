using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodPattern.Pizzas.AmericaStyles
{
    public class AmericaCheesePizza : Pizza
    {
        public AmericaCheesePizza()
        {
            Console.WriteLine("Cheese pizza");
        }
    }
}
