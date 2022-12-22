using DecoratorsPattern.Beverages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorsPattern.Toppings
{
    public class Bubble : Topping
    {
        private readonly IBeverage _wrappedBeverage;

        public Bubble(IBeverage beverage) : base(beverage)
        {
            this._wrappedBeverage = beverage;
        }

        public override string GetDescription()
        {
            return _wrappedBeverage.GetDescription() +  " + bubble";
        }
        public override int Cost()
        {
            return 10 + _wrappedBeverage.Cost();
        }
    }
}
