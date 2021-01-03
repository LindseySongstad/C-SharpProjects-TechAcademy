using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enumerators
{
    class Program
    {
        enum weekDays
        {
            Monday,
            Teusday,
            Wednesday,
            Thursday,
            Friday,
            Saturday,
            Sunday
        }

        static void Main(string[] args)
        {
            try 
            {
                Console.WriteLine("Enter a day of the week: ");
                weekDays day = (weekDays)Enum.Parse(typeof(weekDays), Console.ReadLine(), true);
                Console.WriteLine(day);
            }
            catch 
            {
                Console.WriteLine("Please enter an actual day of the week.");
            }
            Console.ReadLine();
        }
        
    }
}
