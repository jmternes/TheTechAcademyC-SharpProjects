 using System;

namespace MethodsAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Math math = new Math();
            Console.WriteLine("What number would you like to see actions performed on?");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(math.plusOne(a, 1));
            int c = 2;
            Console.WriteLine(math.divideByTwo(a, c));
            int d = 2;
            Console.WriteLine(math.doubleIt(a, d));
        }
    }
}
