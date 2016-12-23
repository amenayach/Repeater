using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepeatorTest
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("================================= RepeatByCount ================================= ");
            Tester.Test("", () =>
            {
                var engine = new Repeator.ObjectModel.RepeatorEngine();
                Console.WriteLine(engine.Repeat("3", "{ id: $i, id2: $b }\\n"));
            });


            Console.ReadKey();
        }
    }
}
