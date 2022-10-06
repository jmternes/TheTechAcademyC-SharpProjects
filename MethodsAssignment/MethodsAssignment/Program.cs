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
            math.plusOne(a, 1);
            int c = 2;
            math.divideByTwo(a, c);
            int d = 2;
            math.doubleIt(a, d);
        }
    }
}
