using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepeatorTest
{
    public class Tester
    {

        public static void Test(string description, Action action)
        {
            try
            {

                if (action != null)
                {
                    action();
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine(description + " >> Passed");
                }

                Console.ForegroundColor = ConsoleColor.Gray;
                Console.WriteLine(description + " >> Skipped");

            }
            catch (Exception ex)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(description + " >> Failed");
                Console.WriteLine("Exception: " + ex.ToString());
            }
        }

    }
}
