using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkingWithStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            //string myString = "My \"so-called\" life";
            // string myString = "What if I need a\nnew line?";
            // string myString = "Go to your c:\\ drive";
            // string myString = @"Go to you c:\ drive";

            string myString = String.Format("{0} = {1}", "First", "Second");

            Console.WriteLine(myString);
        }
    }
}