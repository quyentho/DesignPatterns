using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorsPattern.Beverages
{
    public abstract class Beverage : IBeverage
    {
        public virtual string GetDescription()
        {
            return "A beverage";
        }

        public abstract int Cost();
    }
}
