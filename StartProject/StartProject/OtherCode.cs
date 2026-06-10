using System;
using System.Collections.Generic;
using System.Text;

namespace Idea1
{
    internal class OtherCode
    {
        public static void TestOtherCode()
        {
            char capitalA = '\x0041';
            Console.WriteLine(capitalA);

            string myString = "\x0041BCDE\a";
            Console.WriteLine(myString);

            string verbatim =
                @"The quick
            brown fox
            jumps over the lazy dog.";

            Console.WriteLine(verbatim);

            bool networkOk = true;
            Console.WriteLine(networkOk);
        }

    }
}
