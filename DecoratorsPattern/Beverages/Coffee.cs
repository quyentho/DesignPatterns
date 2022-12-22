using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorsPattern.Beverages
{
    public class Coffee : Beverage
    {
        public override string GetDescription()
        {
            return base.GetDescription() + " (Coffee)";
        }
        public override int Cost()
        {
            return 30;
        }
    }
}
