using DecoratorsPattern.Beverages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorsPattern.Toppings
{
    public class Mocha : Topping
    {
        private readonly IBeverage _wrappedBeverage;

        public override string GetDescription()
        {
            return _wrappedBeverage.GetDescription() +  " + mocha";
        }
        public Mocha(IBeverage beverage) : base(beverage)
        {
            _wrappedBeverage = beverage;
        }

        public override int Cost()
        {
            return 20 + _wrappedBeverage.Cost();
        }
    }
}
