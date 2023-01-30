using DecoratorsPattern.Beverages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorsPattern.Sizes
{
    public class Large : BeverageDecorator
    {
        private readonly IBeverage _wrappedBeverage;

        public Large(IBeverage beverage) : base(beverage)
        {
            this._wrappedBeverage = beverage;
        }

        public override string GetDescription()
        {
            return _wrappedBeverage.GetDescription() + " Size: Large";
        }

        public override int Cost()
        {
            return _wrappedBeverage.Cost() + 20;
        }
    }
}
