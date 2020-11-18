using System;

namespace MathAndComparisonOperators
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Anonymous Income Comparison Program");
            
            Console.WriteLine("Person 1 \nHourly rate?");
            int p1HourlyRate = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Hours worked per week?");
            int p1HoursWorked = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Person 2 \nHourly rate?");
            int p2HourlyRate = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Hours worked per week?");
            int p2HoursWorked = Convert.ToInt32(Console.ReadLine());

            int p1Salary = p1HourlyRate * p1HoursWorked * 52;
            int p2Salary = p2HourlyRate * p2HoursWorked * 52;

            Console.WriteLine("Annual Salary of Person 1:  \n" + p1Salary.ToString());
            Console.WriteLine("Annual Salary of Person 2:  \n" + p2Salary.ToString());

            bool p1Greater = p1Salary > p2Salary;
            Console.WriteLine("Does person 1 make more than person 2?\n" + p1Greater.ToString());
            Console.ReadLine();
        }
    }
}
