using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Pick a number");
            int numberOne = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(numberOne*50);

            Console.WriteLine("Pick a number");
            int numberTwo = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(numberTwo + 25);

            Console.WriteLine("Pick a number");
            int numberThree = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(numberThree/12.5);

            Console.WriteLine("Pick a number");
            int numberFour = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(numberFour > 50);

            Console.WriteLine("Pick a number");
            int numberFive = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(numberFive%7);

            Console.ReadLine();
                
                
            
        }

    }
}
