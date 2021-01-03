using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] colors = { "red", "blue", "yellow", "green", "purple" };


            Console.WriteLine("Pick a number between 0 and 4");
            int colorIndex = Convert.ToInt32(Console.ReadLine());
            if (colorIndex < 0 || colorIndex > 4 )
            {
                Console.WriteLine("That was not a number between 0 and 4");
            }
            else Console.WriteLine(colors[colorIndex]);

            int[] numbers = { 100, 200, 300, 400, 500 };

            Console.WriteLine("Pick a number between 0 and 4");
            int intIndex = Convert.ToInt32(Console.ReadLine());
            if (intIndex < 0 || intIndex > 4)
            {
                Console.WriteLine("That was not a number between 0 and 4");
            }
            else Console.WriteLine(numbers[intIndex]);

            List<string> animals = new List<string>
            {
                "cat", "dog", "tortoise", "squirrel", "rabbit"
            };

            Console.WriteLine("Pick a number between 0 and 4");
            int  animalIndex = Convert.ToInt32(Console.ReadLine());
            if ( animalIndex < 0 ||  animalIndex > 4)
            {
                Console.WriteLine("That was not a number between 0 and 4");
            }
            else Console.WriteLine(animals[ animalIndex]);

            Console.ReadLine();
        }
    }
}
