using System;
using System.Collections.Generic;
using System.Text;

namespace MainMethodAssignment
{
    public class myClass
    {
        public int addNumbers(int a, int b)
        {
            int sum = a + b;
            return sum;
        }

        public int subtractNumbers(decimal c, decimal d)
        {
            int difference = Convert.ToInt32(c - d);
            return difference;
        }

        public int stringToInt(string myString)
        {
            int converted = Convert.ToInt32(myString);
            return converted;
        }
    }
}
