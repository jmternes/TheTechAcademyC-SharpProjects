using System;

namespace ChainingConstructors
{
    class Program
    {
        static void Main(string[] args)
        {
            // const variable
            const string language = "English";
            // var variable
            var word = "Hello";
            Console.WriteLine("{0} in {1} is {0}", word, language);
            Console.ReadLine();
        }
    }
    class Person
    {
        public string name;
        public string password;

        // constructor that takes the name parameter and references another constructor that takes both name and password, including a default value for password.
        
        public Person(string name) : this(name, "password")
        {

        }

        public Person(string name, string password)
        {
            this.name = name;
            this.password = password;
        }
    }
}
