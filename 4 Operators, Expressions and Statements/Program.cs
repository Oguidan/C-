// using System;
// using System.Collections.Generic;
// using System.Linq;
// using System.Text;
// using System.Threading.Tasks;

// namespace Variables
// {
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             /*
//             int x;
//             int y;

//             x = 7;
//             y = x + 3;
            
//             Console.WriteLine(y);
//             */

//             Console.WriteLine("What is your name?");
//             Console.Write("Type your first name: ");
//             string myFirstName;
//             myFirstName = Console.ReadLine();

//             //string myLastName;
//             //Console.Write("Type your last name: ");
//             //myLastName = Console.ReadLine();

//             Console.WriteLine("Type your last name: ");
//             string myLastName = Console.ReadLine();

//             Console.WriteLine("Hello, " + myFirstName + " " + myLastName);
//         }
//     }
// }


//Continue

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorsExpressionsStatements
{
    class Program
    {
        static void Main(string[] args)
        {
            // Variable decleration
            int x, y, a, b;

            // Assignement operator
            x = 3;
            y = 2;
            a = 1;
            b = 0;

            // There are many mathematical operators ...

            // Addition operator
            x = 3 + 4;

            // Subtraction operator
            x = 4 - 3;

            // Multiplication operator
            x = 10 * 5;

            // Division operator
            x = 10 / 5;

            // Order of operations using parenthesis
            x = (x + y) * (a - b);

            // There are many operators used to evaluate value ...

            // Equality operator
            if (x == y)
            {

            }

            // Greater than operator
            if (x > y)
            {

            }

            // Less than operator
            if (x < y)
            {
                
            }

            // Grater or equal to operator
            if (x >= y)
            {

            }

            // Less than or equal to operator
            if (x <= y)
            {

            }

            // There are tow "conditional" operator as well that can
            // be used to expand / enhance an evaluation ...
            // ... and they czn be combined together multiple times.

            // Conditional AND operator ...
            if ((x > y) && (a > b))
            {

            }

            // Conditional OR operator ...
            if ((x > y) || (a > b))
            {

            }

            // Also, here's the in-line conditional operator we learn about in
            // the previous lesson ...
            string message = (x == 1) ? "Car" : "Boat";

            // Member access and Method invocation
            Console.WriteLine("Hi");
        }
    }
}