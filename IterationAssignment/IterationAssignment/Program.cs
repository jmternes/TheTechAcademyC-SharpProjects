using System;
using System.Collections.Generic;
using System.Linq;

namespace IterationAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            // MONDAY --- steps 1-4 look good, but test again. Fix error on step 5 and complete step 6
            //step 1 start
            //one-dimensional array of strings

            string[] greetings = { "Hello ", "Bonjour ", "Hola " };
            Console.WriteLine("Write your name");
            string username = Console.ReadLine();

            //for loop to iterate through the array, and adding the user's input to the end of each element with the second line

            for (int i = 0; i < greetings.Length; i++) {
                greetings[i] = greetings[i] + username;
            }

            // second loop that prints off each string in the array

            for (int i = 0; i < greetings.Length; i++)
            {
                Console.WriteLine(greetings[i]);
            }

            // step 1 complete

            // step 2, create an infinite loop then fix it
            // infinite for loop, where x will never be greater than 50, since we're reducing the value of int x each time, commented out to avoid the infinite loop

            //for (int x = 0; x < 5; x--)
            //{
            //    Console.WriteLine("Stuck in this loop");
            //}

            // fixed version where we'll increment the value of x, so it should iterate only 5 times, instead of forever
            for (int x = 0; x < 5; x++)
            {
                Console.WriteLine("Print 5 times");
            }
            // step 2 complete

            // step 3, loop with a < operator and a <= operator

            for (int y = 0; y < 3; y++)
            {
                Console.WriteLine("Print 3 times");
            }

            for (int z = 0; z <= 3; z++)
            {
                Console.WriteLine("Print 4 times");
            }

            // step 3 complete

            // step 4: list of strings, user input text to search for string, loop ends if match is found

            List<string> stringList = new List<string>();
            stringList.Add("Paris");
            stringList.Add("London");
            stringList.Add("Rome");
            stringList.Add("Athens");
            stringList.Add("Amsterdam");

            Console.WriteLine("Name a major city in Europe to see its index. (Try Paris, London, Rome, Athens, or Amsterdam for best success)");
            string cityAnswer = Console.ReadLine();

            foreach (string value in stringList)
            {
                if (!stringList.Contains(cityAnswer))
                {
                    Console.WriteLine("Too bad... Moving on!");
                    break;
                }
                else if (cityAnswer == value)
                {
                    Console.WriteLine(stringList.IndexOf(value));
                }
            }

            // step 4 complete

            // step 5 start: new string list with identical values included, loop that displays indices matching user text

            List<string> bandsList = new List<string>();
            bandsList.Add("The Beatles");
            bandsList.Add("Led Zeppelin");
            bandsList.Add("The Rolling Stones");
            bandsList.Add("The Beatles");

            Console.WriteLine("Name a rock band. The Beatles, Led Zeppelin, or The Rolling Stones for best results.");

            //user's input stored as userBand
            string userBand = Console.ReadLine();

            // for loop that iterates through the list, if userBand matches a value in the list, we display the index for that value. otherwise, we move on
            for (int i = 0; i < 4; i++)
            {
                if (userBand.Contains(bandsList[i]))
                {
                    Console.WriteLine("Index/indices for this band: " + i);
                }
                else
                {
                    Console.WriteLine("Too bad... Moving on.");
                    
                }
                break;
            }
            
            

            // step 5 complete. 

            // step 6: list of strings with identical values, foreach loop that displays a message showing whether or not the string has appeared

            List<string> dogList = new List<string>();
            dogList.Add("Poodle");
            dogList.Add("Poodle");
            dogList.Add("Black Lab");
            dogList.Add("Pug");

            foreach (string value in dogList)
            {
                if (dogList.Count != dogList.Distinct().Count())
                {
                    Console.WriteLine("Duplicate found!");
                }
            }
        }
    }
}
