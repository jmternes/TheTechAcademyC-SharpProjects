using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractClassAssignment
{
    // public abstract (or base) class created called Person
    public abstract class Person
    {
        // created two properties, first and last name
        public string firstName = "John";
        public string lastName = "Doe";

        // method say name created
        public void SayName()
        {
            Console.WriteLine("Name: " + firstName + " " + lastName);
        }
    }
}
