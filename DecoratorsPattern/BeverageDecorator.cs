using DecoratorsPattern.Beverages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorsPattern
{
    public abstract class BeverageDecorator : Beverage
    {
        public BeverageDecorator(IBeverage beverage)
        {
        }
    }
}
