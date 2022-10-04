using System;
using System.Collections.Generic;

namespace ExceptionAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numList = new List<int>();
            numList.Add(10);
            numList.Add(20);
            numList.Add(40);
            numList.Add(80);

            Console.WriteLine("Hello user. Please select a number.");
            

            try
            {
                int userNum = Convert.ToInt32(Console.ReadLine());
                foreach (int value in numList)
                {
                    int quotient = value / userNum;
                    Console.WriteLine(value + " divided by your number (" + userNum + ") = " + quotient);
                }
            }
            catch (FormatException ex)
            {
                Console.WriteLine("Please type a whole number.");
                return;
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("You can't divide by zero!");
            }
            finally
            {
                Console.ReadLine();
            }
            
        }
    }
}
