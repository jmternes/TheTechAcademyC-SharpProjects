using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractClassAssignment
{
    // class employee created, inherits from person with :
    public class Employee : Person
    {
        public void SayName()
        {
            Console.WriteLine("Person: " + firstName + " " + lastName);
        }
    }
}
