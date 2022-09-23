using System;

namespace WhileAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            // while loop
            int i = 1;
            while (i <= 3)
            {
                Console.WriteLine("This will be displayed 3 times.");
                i++;
            }
            // do while loop
            int x = 2;
            int y = 3;
            do
            {
                int sum = x + y;
                Console.WriteLine(sum);
                x++;
            }
            while (x <= 5);
        }
    }
}
