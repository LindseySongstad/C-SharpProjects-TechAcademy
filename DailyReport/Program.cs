using System;


namespace DailyReport
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("The Tech Academy");
            Console.WriteLine("Student Daily Report");
            
            Console.WriteLine("What is your name?");
            string name = Console.ReadLine();
            
            Console.WriteLine("What course are you on?");
            string course = Console.ReadLine();
            
            Console.WriteLine("What page number?");
            string pageNumString = Console.ReadLine();
            int pageNum = Convert.ToInt32(pageNumString);

            Console.WriteLine("Do you need help with anything? Please answer \"true\" or \"false\"");
            string helpString = Console.ReadLine();
            bool help = Convert.ToBoolean(helpString);

            Console.WriteLine("Where there any positive experiences you'd like to share? Please give specifics");
            string exp = Console.ReadLine();

            Console.WriteLine("Is there any other feedback you'd like to provide? Please be specific");
            string feedback = Console.ReadLine();

            Console.WriteLine("How many hours did you study today?");
            string hoursString = Console.ReadLine();
            float hours = float.Parse(hoursString);

            Console.WriteLine("Thank you for your answers. An instructor will respond shortly. Have a great day!");

        }
    }
}
