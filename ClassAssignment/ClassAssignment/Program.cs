using System;

namespace ClassAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            // instantiation nation
            classy classy = new classy();

            // user input set to int a, then calling the method with that number. will display half of int a
            Console.WriteLine("Enter a number");
            int a = Convert.ToInt32(Console.ReadLine());
            classy.halfIt(a);

            // method without parameters, just serves to write a sentence on the console.
            classy.noParameters();

            // out parameter method. declare variable c without giving value, then pass the variable with out keyword
            int b;
            classy.outParameter(out b);
            Console.WriteLine("Addition of the value: {0}", b);

            // method overloaded
            classy.noParameters(10);

            
        }
    }
}
