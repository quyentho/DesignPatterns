using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleFactoryPattern.Pizzas
{
    public class CheesePizza : Pizza
    {
        public CheesePizza()
        {
            Console.WriteLine("Cheese pizza");
        }
    }
}
