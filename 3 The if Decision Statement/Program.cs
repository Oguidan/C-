﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decisions
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Console.WriteLine("Bob's Big Giveaway");
            Console.Write("Choose a door: 1, 2 or 3: ");
            string userValue = Console.ReadLine();

            String message = " ";

            if (userValue == "1")
            {
                message = "You won a new car!";
            }
            else if (userValue == "2")
            {
                message = "You won a new boat!";
            }
            else if (userValue == "3")
            {
                message = "You won a new cat";
            }
            else
            {
                message = "Sorry, we don't understand. ";
                message += "You Lose";
            }
            Console.WriteLine(message);
            */
            Console.WriteLine("Bob's Big Giveaway");
            Console.Write("Choose a door: 1, 2 or 3: ");
            string userValue = Console.ReadLine();

            string message = (userValue == "1") ? "boat" : "stand of lint";

            //Console.Write("You won a ");
            //Console.Write(message);
            //Console.Write(".");
            
            //Console.WriteLine("You won a {0}.", message);
            Console.WriteLine("You entered: {0}, therefore you won a {1}.", userValue, message);
        }
    }
}