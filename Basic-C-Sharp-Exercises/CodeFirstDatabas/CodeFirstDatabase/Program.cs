using System;
using System.Data.Entity;

namespace CodeFirstDatabase
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var ctx = new StudentContext())
            {
                var stud = new Student();
                stud.FirstName = "Lindsey";
                stud.LastName = "Songstad";

                ctx.Students.Add(stud);
                ctx.SaveChanges();

            }
        }
    }
}
