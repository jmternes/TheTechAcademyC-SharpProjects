using System;

namespace MethodsObjectsAssignment
{
    class Program
    {
        public static void Main(string[] args)
        {
            // class instantiation
            Employee e = new Employee();
            // initializing Employee objects with new first and last names
            e.FirstName = "Sample";
            e.LastName = "Student";
            // calling the superclass method on said object
            e.SayName();
        }
    }
}
