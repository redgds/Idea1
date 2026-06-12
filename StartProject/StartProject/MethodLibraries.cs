using System;
using System.Collections.Generic;
using System.Runtime.Intrinsics.Arm;
using System.Text;

namespace Idea1
{
    internal class MethodLibraries
    {
        public static string ReadString(string prompt)
        {
            string result;
            do
            {
                Console.Write(prompt);
                result = Console.ReadLine();
            } while (string.IsNullOrEmpty(result));
            return result;
        }
        public static int ReadInt(string prompt, int low, int high)
        {
            int result = 0;
            do
            {
                Console.Write(prompt + " between " + low + " and " + high + ": ");
                string resultString = Console.ReadLine();
                result = int.Parse(resultString);
            } while ((result < low) || (result > high));
            return result;
        }
    }
}
