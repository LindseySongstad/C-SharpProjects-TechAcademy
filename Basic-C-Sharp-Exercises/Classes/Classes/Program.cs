using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            MathClass mc = new MathClass();

            Console.WriteLine("Enter a number: ");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("If you want, you may enter a second number: ");
            string input = Console.ReadLine();  
            if (input == "")  // if a number was not entered, use ony first input in function
            {
                Console.WriteLine(mc.MultiplyTwoNumbers(num1));
            }
            else  // otherwise pass second input to function also
            {
                int num2 = Convert.ToInt32(input);
                Console.WriteLine(mc.MultiplyTwoNumbers(num1, num2));
            }

            Console.ReadLine();
        }
    }
}
