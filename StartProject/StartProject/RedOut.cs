using System;
using System.Collections.Generic;
using System.Text;

namespace Idea1
{
    internal class RedOut
    {
        static void AddOne(int i)
        {
            i = i + 1;
            Console.WriteLine("i is: " + i);
        }

        static void AddOneToRefParam(ref int i)
        {
            i = i + 1;
            Console.WriteLine("i is: " + i);
        }

        static void GetCoords(out int x, out int y)
        {
            x = 10;
            y = 20;
        }


        public static void TestAddOne()
        {
            int test = 20;
            AddOne(test);   
            Console.WriteLine("test is: " + test);
        }
        // i is: 21
        // test is: 20


        public static void TestAddRef()
        {
            int test = 20;
            AddOneToRefParam(ref test);
            Console.WriteLine("test is: " + test);
        }
        // i is: 21
        // test is: 21


        public static void TestGetCoords()
        {
            GetCoords(out int a, out int b);
            Console.WriteLine(a + ", " + b);
        }
    }
}
