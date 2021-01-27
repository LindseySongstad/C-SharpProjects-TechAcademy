using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structs1
{
    class Program
    {
        static void Main(string[] args)
        {
            Number num = new Number();
            Console.WriteLine("Enter a number:");
            num.amount = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine(num.amount);

            Console.Read();
        }

        public struct Number
        {
            public decimal amount;
        }
    }
}
