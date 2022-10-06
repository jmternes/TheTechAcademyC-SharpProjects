using System;

namespace MainMethodAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            myClass classy = new myClass();
            Console.WriteLine(classy.addNumbers(3, 6));
            Console.WriteLine(classy.subtractNumbers(19.5m, 18.5m));
            Console.WriteLine(classy.stringToInt("8"));
        }
    }
}
