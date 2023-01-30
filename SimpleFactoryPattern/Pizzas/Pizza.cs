using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleFactoryPattern.Pizzas
{
    public abstract class Pizza
    {
        public void Prepare()
        {
            Console.WriteLine("Preparing");
        }

        public void Bake()
        {
            Console.WriteLine("Baking");
        }

        public void Cut()
        {
            Console.WriteLine("Cut into pieces");
        }
        public void Box()
        {
            Console.WriteLine("Boxing the pizza");
        }
    }
}
