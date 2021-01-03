using System;
using System.Collections.Generic;
using System.Text;
using System.Data.Entity;


namespace CodeFirstDatabase
{
    public class Student
    {
        public int StudentId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime? DateOfBirth { get; set; }

    }
}
