using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorsPattern.Beverages
{
    public class MilkTea : Beverage
    {
        public override string GetDescription()
        {
            return base.GetDescription() + " (Milk tea)";
        }
        public override int Cost()
        {
            return 70;
        }
    }
}
