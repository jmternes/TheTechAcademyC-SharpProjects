using System;

namespace OverloadingOperators
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee e1 = new Employee();
            Employee e2 = new Employee();
            e1.Id = 1;
            e1.firstName = "Spongebob";
            e1.lastName = "Squarepants";
            e2.Id = 2;
            e2.firstName = "Squidward";
            e2.lastName = "Tentacles";
            Console.WriteLine(e1 == e2);
            Console.ReadLine();
        }
        
    }
}
