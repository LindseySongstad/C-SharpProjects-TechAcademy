using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandling
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int> { 10, 20, 30, 40, 50 };
            Console.WriteLine("Pick a number");

            try 
            {
                int input = Convert.ToInt32(Console.ReadLine());

                foreach (int number in numbers)
                {
                    Console.WriteLine(number + " divided by " + input + " equals " + number / input);
                }
                Console.ReadLine();
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Please do not deivide by zero");
            }
            catch (FormatException) 
            {
                Console.WriteLine("Please enter a whole number");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally 
            {
                Console.ReadLine();
            }
        }
    }
}
