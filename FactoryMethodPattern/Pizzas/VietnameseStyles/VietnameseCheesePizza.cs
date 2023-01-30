using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodPattern.Pizzas.Vietnamese
{
    public class VietnameseCheesePizza : Pizza
    {
        public VietnameseCheesePizza()
        {
            Console.WriteLine("Cheese pizza");
        }
    }
}
