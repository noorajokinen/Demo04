﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonApplication
{
    class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public int Age { get; set; }
        public string PhoneNumber { get; set; }


        //default constructor
        public Person()
        {
        }

        //constructor takes person firstname and lastname as a parameter
        public Person(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = LastName;
    
        }
        //just one method what Person can do
        public void PersonMethod()
        {
            Console.WriteLine("This method belongs to Person!");
        }
        public override string ToString()
        {
            return FirstName + " " + LastName + " " + Address + " " + Age + " " + PhoneNumber;

        }
    }
}
