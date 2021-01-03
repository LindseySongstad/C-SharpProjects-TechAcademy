using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TryCatch
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("How old are you?");
            int age = 0;

            try
            {
                age = Convert.ToInt32(Console.ReadLine());
                if (age <= 0)
                {
                    throw new NegativeNumberExeption();
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Please enter digits only, no decimals");
                Console.ReadLine();
                return;
            }
            catch (NegativeNumberExeption)
            {
                Console.WriteLine("Please enter a number greater than zero.");
                Console.ReadLine();
                return;
            }
            catch (Exception)
            {
                Console.WriteLine("An error occurred, please contact your system administrator.");
                Console.ReadLine();
                return;
            }

            int currentYear = DateTime.Now.Year;
            int birthYear = currentYear - age;

            Console.WriteLine("You were born in " + birthYear);
            Console.ReadLine();
        }
        
    }
}
