using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FileIO
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter some numbers. When you are finished type \"done\"");
            while (true)
            {
                string answer = Console.ReadLine().ToLower();
                if (answer == "done") break;

                using (StreamWriter file = new StreamWriter(@"C:\Users\linds\OneDrive\Documents\Logs\log2.txt", true))
                {
                    file.WriteLine(answer);
                }
            }
            Console.WriteLine("You entered: ");
            Console.WriteLine(File.ReadAllText(@"C:\Users\linds\OneDrive\Documents\Logs\log2.txt"));
            Console.ReadLine();
        }
    }
}
