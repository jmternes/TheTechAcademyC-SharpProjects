using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        string[] stringList = { "John", "Paul", "Ringo", "George" };
        Console.WriteLine("Hello user. Please select an index of 0, 1, 2, or 3.");
        int stringChoice = Convert.ToInt32(Console.ReadLine());
        string errorMessage = "You didn't select one of the options!";
        if (stringChoice >= 4 || stringChoice < 0)
        {
            Console.WriteLine(errorMessage);

        }
        else
        {
            Console.WriteLine("You selected " + stringList[stringChoice]);
        }

        int[] numArray = { 0, 1, 2, 3 };
        Console.WriteLine("Hello again, user. Please select an index of 0, 1, 2, or 3");
        int numChoice = Convert.ToInt32(Console.ReadLine());
        if (numChoice >= 4 || numChoice < 0)
        {
            Console.WriteLine(errorMessage);
        }
        else
        {
            Console.WriteLine("You selected " + numArray[numChoice]);
        }

        List<String> List = new List<String>();
        List.Add("Hello");
        List.Add("Bonjour");
        List.Add("Hola");
        Console.WriteLine("Last one, user. Please select an index of 0, 1, or 2");
        int stringChoice2 = Convert.ToInt32(Console.ReadLine());
        if (stringChoice2 > 2 || stringChoice2 < 0)
        {
            Console.WriteLine(errorMessage);
        }
        else
        {
            Console.WriteLine(List[stringChoice2]);
        }
    }
}

