using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern
{
    public class ForecastDisplay: Display
    {
        public ForecastDisplay()
        {
        }

        public override void DisplayData()
        {
            Console.WriteLine();
            Console.WriteLine("Forecast display");
            base.DisplayData();

        }
    }
}
