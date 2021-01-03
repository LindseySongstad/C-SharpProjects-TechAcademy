using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes2
{
    class Program
    {
        static void Main(string[] args)
        {
            MathClass mc = new MathClass();

            mc.method1(5, 10);

            int number1 = 4;
            int number2 = 7;

            mc.method1(num1: number1, num2: number2);

            Console.Read();
        }
    }
}
