using System;
using System.Text;


namespace Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            string concat = "Lorem ipsum dolor sit amet, " + "onsectetur adipiscing elit, " + "sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.";
            Console.WriteLine(concat);
            Console.WriteLine(concat.ToUpper());

            StringBuilder sb = new StringBuilder(concat);
            sb.Append("Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat.");
            sb.Append("Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur.");
            sb.Append("Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.");

            Console.WriteLine(sb);
            Console.ReadLine();
        }
    }
}
