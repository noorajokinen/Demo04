using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonApplication
{
    class Student:Person
    {
        public string StudentID { get; set; }

        //default constructor
        public Student()
        {
        }

        //kutsutaan "base" luokasta konstuktori ja parametrit
        public Student(string firstName, string lastName, string studentID)
            :base(firstName, lastName)
        {
            StudentID = studentID;
        }

        public void StudentMethod()
        {
            Console.WriteLine("This method belong to Student!");
        }

        public override string ToString()
        {
            return base.ToString() + " " + StudentID;
        }
    }
}
