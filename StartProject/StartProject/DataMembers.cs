using System;
using System.Collections.Generic;
using System.Text;

namespace Idea1
{
    internal class DataMembers
    {
        static int LocalVar = 0;
        public static void OtherMethod()
        {
            LocalVar = 99;
        }

        public static void PrintLocalVar()
        {
            Console.WriteLine("LocalVar is: " + LocalVar);
            OtherMethod();
            Console.WriteLine("LocalVar is: " + LocalVar);
        }
    }
}