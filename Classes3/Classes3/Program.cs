using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes3
{
    class Program
    {
        static void Main(string[] args)
        {
            OutputClass oc = new OutputClass();

            Console.WriteLine("Enter a number:");
            int input = Convert.ToInt32(Console.ReadLine());

            oc.method1(input, out int halved);
            Console.WriteLine(halved);

            StaticClass.printSomething();

            Console.ReadLine();

        }
    }
}
