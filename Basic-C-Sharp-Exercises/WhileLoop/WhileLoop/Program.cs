using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhileLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Pick a number: ");
            int x = Convert.ToInt32(Console.ReadLine());
            int i = 0;
            while(i <= x)
            {
                Console.WriteLine(i);
                i++;
            }

            Console.WriteLine("Pick a number: ");
            int y = Convert.ToInt32(Console.ReadLine());
            int j = 0;
            do
            {
                Console.WriteLine(j);
                j++;
            }
            while (j <= y);

            Console.ReadLine();
        }
    }
}
