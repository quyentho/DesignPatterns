using DecoratorsPattern.Beverages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorsPattern.Sizes
{
    public class Small : BeverageDecorator
    {
        private readonly IBeverage _wrappedBeverage;

        public Small(IBeverage beverage) : base(beverage)
        {
            this._wrappedBeverage = beverage;
        }

        public override int Cost()
        {
            return _wrappedBeverage.Cost() + 0;
        }
    }
}
