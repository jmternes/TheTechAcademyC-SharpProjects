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
        }
        
    }
}
