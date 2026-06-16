using System;
using System.Collections.Generic;
using System.Text;

namespace Idea1
{
    internal class SwitchConstruction
    {
        public static void TestSwitch()
        {
            Console.WriteLine("Enter the day of the week (1-7): ");
            var DayString = Console.ReadLine();

            switch (DayString)
            {
                case "1":
                case "one":
                    Console.WriteLine("Monday");
                    break;
                case "2":
                    Console.WriteLine("Tuesday");
                    break;
                case "3":
                    Console.WriteLine("Wednesday");
                    break;
                case "4":
                    Console.WriteLine("Thursday");
                    break;
                case "5":
                    Console.WriteLine("Friday");
                    break;
                case "6":
                    Console.WriteLine("Saturday");
                    break;
                case "7":
                    Console.WriteLine("Sunday");
                    break;
                default:
                    Console.WriteLine("Invalid day number.");
                    break;
            }
        }
    }
}