using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Student
    {
        public string? FirstName { get; set; }
        public int Id { get; set; }

        public Student()
        {
            
        }
        public Student(string firstName, int id)
        {
            FirstName = firstName;
            Id = id;
        }
    }
}
