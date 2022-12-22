using DecoratorsPattern.Beverages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorsPattern.Toppings
{
    public class Berry : Topping
    {
        private readonly IBeverage _wrappedBeverage;

        public Berry(IBeverage beverage) : base(beverage)
        {
            _wrappedBeverage = beverage;
        }

        public override string GetDescription()
        {
            return _wrappedBeverage.GetDescription() +  " + berry";
        }

        public override int Cost()
        {
            return 50 + _wrappedBeverage.Cost();
        }
    }
}
