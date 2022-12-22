using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorsPattern.Beverages
{
    public class BlackTea : Beverage
    {
        public override string GetDescription()
        {
            return base.GetDescription() + " (Black tea)";
        }
        public override int Cost()
        {
            return 50;
        }
    }
}
