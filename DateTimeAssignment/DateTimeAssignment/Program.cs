using System;
using System.IO;

namespace DateTimeAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            // datetime type called currentDate gives us current date, then prints to console.
            DateTime currentDate = DateTime.Now;
            Console.WriteLine(currentDate);

            // asks user for a number, stores it as an int called userNum
            Console.WriteLine("Please enter a number.");
            int userNum = Convert.ToInt32(Console.ReadLine());

            // new datetime type called futureTime, uses the AddHours method that takes the user's number as our value passed in, then prints to console.
            DateTime futureTime = currentDate.AddHours(userNum);
            Console.WriteLine(futureTime);
        }
    }
}
