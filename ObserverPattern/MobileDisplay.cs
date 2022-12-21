﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern
{
    public class MobileDisplay: Display
    {
        public MobileDisplay(ISubject weatherData) : base(weatherData)
        {
        }

        public override void DisplayData()
        {
            Console.WriteLine();
            Console.WriteLine("Mobile Display");
            base.DisplayData();
        }
    }
}
