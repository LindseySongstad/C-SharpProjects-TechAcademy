using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateTime1
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime dt = DateTime.Now;
            
            Console.WriteLine(dt);
            Console.WriteLine("Enter a number: ");
            double x = Convert.ToDouble(Console.ReadLine());

            DateTime later = dt.AddHours(x);

            Console.WriteLine($"In {x} hours, it will be {later}");

            Console.Read();
        }
    }
}
