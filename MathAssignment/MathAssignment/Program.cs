using System;

namespace MathAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Anonymous Income Comparison Program");
            Console.ReadLine();
            Console.WriteLine("Person 1");
            Console.WriteLine("What is your hourly rate?");
            int hr1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("How many hours do you work per week?");
            int hwpw1 = Convert.ToInt32(Console.ReadLine());
            int salary1 = hr1 * hwpw1 * 52;
            Console.WriteLine("Person 2");
            Console.WriteLine("What is your hourly rate?");
            int hr2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("How many hours do you work per week?");
            int hwpw2 = Convert.ToInt32(Console.ReadLine());
            int salary2 = hr2 * hwpw2 * 52;
            Console.WriteLine("Annual Salary of Person 1: " + salary1);
            Console.WriteLine("Annual Salary of Person 2: " + salary2);
            Console.WriteLine("Does Person 1 make more money than Person 2?");
            bool isPerson1Greater = salary1 > salary2;
            Console.WriteLine(isPerson1Greater);
            Console.ReadLine();
        }
    }
}
