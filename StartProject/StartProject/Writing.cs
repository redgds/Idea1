using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace Idea1
{
    internal class Writing
    {
        public static void StreamWriting()
        {
            using (StreamWriter writer = new StreamWriter("output.txt"))
            {
                writer.WriteLine("Hello, World!");
            }
        }
        public static void Reading()
        {
            using (StreamReader reader = new StreamReader("output.txt"))
            {
                string content = reader.ReadToEnd();
                Console.WriteLine(content);
            }
        }
    }
    
}
