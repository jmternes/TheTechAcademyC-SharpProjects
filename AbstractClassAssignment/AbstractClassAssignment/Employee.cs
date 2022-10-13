using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractClassAssignment
{
    // class employee created, inherits from person with :
    public class Employee : Person, IQuittable
    {
        public void SayName()
        {
            Console.WriteLine("Person: " + firstName + " " + lastName);
        }
        // polymorphism to change the method's implementation
        public void Quit()
        {
            Console.WriteLine("I quit!");
        }
    }
}
