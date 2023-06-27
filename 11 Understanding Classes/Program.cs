using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleClasses
{
    class Program
    {
        static void Main(string[] args)
        {
            car myCar = new car();
        }
    }

    class car
    {
        public string Make {get; set;}
        public string Model {get; set;}
        public int Year {get; set;}
        public string Color {get; set;}
    }
}