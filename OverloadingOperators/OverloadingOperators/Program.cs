using System;

namespace OverloadingOperators
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee e1 = new Employee();
            Employee e2 = new Employee();
            Console.WriteLine(e1 == e2);
        }
        
    }
}
