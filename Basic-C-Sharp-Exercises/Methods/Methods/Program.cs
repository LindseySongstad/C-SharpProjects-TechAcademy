using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            math m = new math();

            //Console.WriteLine("Pick a number");
            //int input = Convert.ToInt32(Console.ReadLine());
            
            //Console.WriteLine(input + " times two equals " + m.timesTwo(input));
            //Console.WriteLine(input + " times five equals " + m.timesFive(input));
            //Console.WriteLine(input + " times ten equals " + m.timesTen(input));

            int integer = 3;
            Console.WriteLine("Int {0} times ten equals {1}", integer, m.timesTen(integer));

            decimal dec = 3.5m;
            Console.WriteLine("Decimal {0} times ten equals {1}",dec, m.timesTen(dec));

            string str = "3";
            Console.WriteLine("String {0} times ten equals {1}", str, m.timesTen(str));

            Console.ReadLine();

        }
    }
}
