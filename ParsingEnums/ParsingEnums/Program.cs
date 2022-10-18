using System;

namespace ParsingEnums
{
    class Program
    {
        public enum days
        {
            Monday,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday,
            Sunday
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter the current day");
            try
            {
                // Enum.Parse method will return the enum type
                days currentDay = (days)Enum.Parse(typeof(days),Console.ReadLine());
                Console.WriteLine("Today is: " + currentDay);
            }
            catch
            {
                Console.WriteLine("Please enter an actual day of the week.");
            }
            
        }
    }
}
