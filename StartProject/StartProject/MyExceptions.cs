using System;
using System.Collections.Generic;
using System.Text;

namespace Idea1
{
    internal class MyExceptions
    {
        public static void CatchExceptions()
        {
            int age;

            try
            {
                Console.Write("Enter your age: ");
                age = int.Parse(Console.ReadLine());
                if (age < 0 || age > 120)
                {
                    //throw new Exception("Invalid age value.");
                    throw new ArgumentOutOfRangeException("age", "Age must be between 0 and 120.");
                    //throw new Exception();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);

            }
            finally
            {
                Console.WriteLine("Continue");
            }
        }
    }
}
