using System;

namespace VoidMethodAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            // class instantiation
            myClass myClass = new myClass();

            // calling the method, passing 2 numbers
            myClass.subtract(10, 5);

            // calling the method, parameters by name
            int a = 20;
            int b = 10;
            myClass.subtract(a, b);
        }
    }
}
