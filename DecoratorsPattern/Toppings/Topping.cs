using DecoratorsPattern.Beverages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorsPattern.Toppings
{
    public abstract class Topping : Beverage
    {
        private readonly IBeverage _beverage;

        public Topping(IBeverage beverage)
        {
            _beverage = beverage;
        }
    }
}
