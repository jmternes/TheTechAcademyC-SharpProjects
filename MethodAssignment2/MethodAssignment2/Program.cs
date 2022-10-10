using System;

namespace MethodAssignment2
{
    class Program
    {
        static void Main(string[] args)
        {
            // instantiate the class
            myClass myClass = new myClass();

            // ask the user for number(s), take user's input to set the value of int a
            Console.WriteLine("Please input 2 numbers, one at a time. (Or just 1 number)");
            int a = Convert.ToInt32(Console.ReadLine());
            
            // a try block for if the user enters a second value for b
            try
            {
                int b = Convert.ToInt32(Console.ReadLine());
                int result = myClass.mathFun(a, b);
                Console.WriteLine("Result: " + result);
            }
            
            // if no second number is given, we run the function with the optional parameter, which was set to 1 in myClass

            catch
            {
                int result = myClass.mathFun(a);
                Console.WriteLine("Result: " + result);
            }
            
        }
    }
}
