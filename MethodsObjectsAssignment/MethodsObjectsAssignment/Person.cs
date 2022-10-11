using System;
using System.Collections.Generic;
using System.Text;

namespace MethodsObjectsAssignment
{
    // new class called person, with properties first and last name. void method with no parameters,
    public class Person
    {
        public string FirstName = "Clark";
        public string LastName = "Kent";

        public void SayName()
        {
            Console.WriteLine("Name: " + FirstName + " " + LastName);
        }
    }
}
