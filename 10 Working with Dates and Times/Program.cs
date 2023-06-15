﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatesAndTimes
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime myValue = DateTime.Now;
            // Console.WriteLine(myValue.ToString());
            // Console.WriteLine(myValue.ToShortDateString());
            // Console.WriteLine(myValue.ToShortTimeString());
            // Console.WriteLine(myValue.ToLongDateString());
            // Console.WriteLine(myValue.ToLongTimeString());

            // Console.WriteLine(myValue.AddDays(3).ToLongDateString());
            // Console.WriteLine(myValue.AddHours(3).ToLongTimeString());
            // Console.WriteLine(myValue.AddDays(-3).ToLongDateString());

            // Console.WriteLine(myValue.Month);

            // DateTime myBirthday = new DateTime(2001, 05, 06);
            // Console.WriteLine(myBirthday.ToShortDateString());

            DateTime myBirthday = DateTime.Parse("05/06/2001");
            TimeSpan myAge = DateTime.Now.Subtract(myBirthday);
            Console.WriteLine(myAge.TotalDays);
        }
    }
}