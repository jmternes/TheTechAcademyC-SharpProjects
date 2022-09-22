using System;

namespace BranchingAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Package Express. Please follow the instructions below.");
            Console.WriteLine("How much does your package weigh?");
            int packageWeight = Convert.ToInt32(Console.ReadLine());
            if (packageWeight > 50)
            {
                Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day.");
            }
            else
            {
                Console.WriteLine("What is the width of your package?");
            }
           
            int packageWidth = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("What is the height of your package?");
            int packageHeight = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("What is the length of your package?");
            int packageLength = Convert.ToInt32(Console.ReadLine());
            if (packageWidth + packageHeight + packageLength > 50)
            {
                Console.WriteLine("Package too big to be shipped via Package Express.");
                Console.ReadLine();
            }
            else
            {
                int cost = (packageLength * packageWidth * packageHeight) * packageWeight / 100;
                Console.WriteLine("Your estimated total for shipping this package is: $" + cost + ".00\nThank you!");
                Console.ReadLine();
            }
        }
    }
}
