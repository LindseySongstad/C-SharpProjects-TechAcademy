using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    public class Employee : Person, IQuittable
    {
        public Employee(string first, string last, int Id)
        {
            //things = new List();
            firstName = first;
            lastName = last;
            id = Id;
        }
        
        public int id { get; set; }
        //public List<T> things { get; set; }


        public override void SayName()
        {
            Console.WriteLine("Name: {0} {1}", firstName, lastName);
        }
        public void Quit()
        {
            Console.WriteLine("I quit!");
        }
        //public static bool operator ==(Employee<T> emp1, Employee<T> emp2)
        //{
        //    return (emp1.id == emp2.id);
        //}
        //public static bool operator !=(Employee<T> emp1, Employee<T> emp2)
        //{
        //    return !(emp1.id == emp2.id);
        //}
    }
}
