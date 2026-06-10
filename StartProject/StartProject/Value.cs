// Value.cs

using System;
using System.Collections.Generic;
using System.Text;

namespace Idea1
{
    internal class Value
    {
        public static double ReadValue(
    string prompt,
    double low,
    double high)
        {
            double result = 0;
            do
            {
                Console.WriteLine(prompt + " between " + low + " and " + high);
                string resultString = Console.ReadLine();
                result = double.Parse(resultString);
            } while ((result < low) || (result > high));
            return result;
        }
    }
}
