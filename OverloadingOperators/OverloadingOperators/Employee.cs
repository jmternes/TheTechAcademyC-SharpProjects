using System;
using System.Collections.Generic;
using System.Text;

namespace OverloadingOperators
{
    // class called Employee created
    public class Employee
    {
        public int Id { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }

        // overloading the == operator, with employee objects e1 and e2
        public static bool operator ==(Employee e1, Employee e2)
        {
            if (e1.Id == e2.Id)
            {
                return true;
            }
            else
            {
                return false;
            }
        }



        // Comparison operators are overloaded in pairs, so the same overloading method for the opposite !=
        public static bool operator !=(Employee e1, Employee e2)
        {
            if (e1.Id != e2.Id)
            {
                return false;
            }
            else
            {
                return true;
            }

        }

    }
}
