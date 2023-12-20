using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectLifeTime
{
    class Program {
        static void Main(string[] args) {
            Car myCar = new Car();

            /*
            myCar.Make = "Oldmobile";
            myCar.Model = "Cutlas Supreme";
            myCar.Year = 1986;
            myCar.Color = "Silver";
            */

            Car myOtherCar;
            myOtherCar = myCar;

            Console.WriteLine("{0} {1} {2} {3}", myOtherCar.Make, myOtherCar.Model, myOtherCar.Year, myOtherCar.Color);

            myOtherCar.Model = "98";

            Console.WriteLine("{0} {1} {2} {3}", myCar.Make, myCar.Model, myCar.Year, myCar.Color);

            myOtherCar = null;

            /*
            Console.WriteLine("{0} {1} {2} {3}", myOtherCar.Make, myOtherCar.Model, myOtherCar.Year, myOtherCar.Color);
            */

            myCar = null;
        }
    }

    class Car {
        public string Make {get; set;}
        public string Model {get; set;}
        public int Year {get; set;}
        public string Color {get; set;}

        public Car()
        {
            Make = "Nissan";
        }
    }
}