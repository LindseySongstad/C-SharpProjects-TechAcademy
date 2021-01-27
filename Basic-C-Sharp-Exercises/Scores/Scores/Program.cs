using System;

namespace Scores
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter your first name.");
            string date = DateTime.Today.ToShortDateString();
            string uName = Console.ReadLine();
            string msg = $"\n Welcome back {uName}. Today is {date}.";
            Console.WriteLine(msg);

            string path = @"C:\Users\linds\source\repos\Scores\Scores\studentScores.txt";
            string[] lines = System.IO.File.ReadAllLines(path); 
            
            double tScore = 0;

            Console.WriteLine("\n Student Scores: \n");
            foreach(string line in lines)
            {
                Console.WriteLine("\n" + line);
                double score = Convert.ToDouble(line);
                tScore += score;
            }

            double avgScore = tScore / lines.Length;
            Console.WriteLine("\n Total of " + lines.Length + " student scores. \t Average score: " + avgScore);   ;
        }
    }
}
