 using System;

namespace MethodsAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please select a number");
            int a = 1;
            int b = Convert.ToInt32(Console.ReadLine());
            plusOne(a, b);
            Console.ReadLine();
            Console.WriteLine("And another number...");
            int c = Convert.ToInt32(Console.ReadLine());
            int d = 2;
            divideByTwo(c, d);
            Console.ReadLine();
            Console.WriteLine("One more number! Let's double it.");
            int e = Convert.ToInt32(Console.ReadLine());
            int f = 2;
            doubleIt(e, f);
            Console.ReadLine();
        }

        static void plusOne(int a, int b)
        {

            int result = a + b;

            Console.WriteLine(result);

        }

        static void divideByTwo(int c, int d)
        {
            int result = c / d;
            Console.WriteLine(result);
        }

        static void doubleIt(int e, int f)
        {
            int result = e * f;
            Console.WriteLine(result);
        }
        
    }
}
