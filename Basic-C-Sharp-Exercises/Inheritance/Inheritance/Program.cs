using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee  emp1 = new Employee ("Joe", "Smith", 1);
            Employee  emp2 = new Employee ("Joe", "Jones", 2);
            Employee  emp3 = new Employee ("Joe", "Doe", 3);
            Employee  emp4 = new Employee ("John", "Doe", 4);
            Employee  emp5 = new Employee ("Jane", "Doe", 5);
            Employee  emp6 = new Employee ("Emily", "Smith", 6);
            Employee  emp7 = new Employee ("Ashley", "Jackson", 7);
            Employee  emp8 = new Employee ("Jim", "Garcia", 8);
            Employee  emp9 = new Employee ("Josh", "Johnson", 9);
            Employee  emp10 = new Employee ("Barbara", "Smith", 10);

            List<Employee > empList = new List<Employee > { emp1, emp2, emp3, emp4, emp5, emp6, emp7, emp8, emp9, emp10 };

            //2.Using a foreach loop, create a new list of all employees with the first name "Joe".

            List<Employee > joeList = new List<Employee >();
            foreach (Employee  emp in empList)
            {
                if (emp.firstName == "Joe") 
                {
                    joeList.Add(emp);
                }
            }

            foreach (Employee  emp in joeList)
            {
                Console.WriteLine("{0} {1} Id = {2}", emp.firstName, emp.lastName, emp.id);
            }


            //3.Perform the same action again, but this time with a lambda expression.

            List<Employee> joeList2 = empList.Where(x => x.firstName == "Joe").ToList();

            foreach (Employee emp in joeList2)
            {
                Console.WriteLine("{0} {1} Id = {2}", emp.firstName, emp.lastName, emp.id);
            }


            //4.Using a lambda expression, make a list of all employees with an Id number greater than 5.

            List<Employee> empList2 = empList.Where(x => x.id > 5).ToList();

            foreach (Employee emp in empList2)
            {
                Console.WriteLine("{0} {1} Id = {2}", emp.firstName, emp.lastName, emp.id);
            }

            Console.ReadLine();
        }
    }
}
