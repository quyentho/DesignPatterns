using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern
{
    public class StatisticsDisplay: Display
    {
        public override void DisplayData()
        {

            Console.WriteLine();
            Console.WriteLine("StatisticsDisplay");
            base.DisplayData();
        }
    }
}
