using System;

namespace AbstractClassAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee e = new Employee();
            e.firstName = "Sample";
            e.lastName = "Student";
            e.SayName();
            Console.ReadLine();
            //calling the method from employee class
            //polymorphism allows this method to be different than the abstract method
            e.Quit();
        }
        
    }
}
