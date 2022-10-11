using System;
using System.Collections.Generic;
using System.Text;

namespace ClassAssignment
{
    class classy
    {
        public void halfIt(int a)
        {
            int result = a / 2;
            Console.WriteLine(result);
        }

        // method with no parameters
        public void noParameters()
        {
            Console.WriteLine("2 + 2 = " + 4);
        }

        // method with out parameter, += operand to add and assign the result to b
        public void outParameter(out int b)
        {
            b = 20;
            b += 2;
        }

       // method overloading, by changing number of parameters
        public void noParameters(int i = 0)
        {
            Console.WriteLine("2 + 2 = " + 4 + " and here's our argument: " + i);
        }
    }

    // make a static class, empty but this is how!

    static class Static_Class
    {

    }
}
