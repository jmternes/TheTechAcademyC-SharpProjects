using System;
using System.Collections.Generic;
using System.Linq;

namespace LambdaAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            // creating a list of 10 employees with their properties and assigned values
            List<Employee> employeeList = new List<Employee> {
                new Employee {firstName="Joe", lastName="Dirt", Id=0},
                new Employee {firstName="Joe", lastName="Dimaggio", Id=1},
                new Employee {firstName="Lebron", lastName="James", Id=2},
                new Employee {firstName="Michael", lastName="Jackson", Id=3},
                new Employee {firstName="Michael", lastName="Jordan", Id=4},
                new Employee {firstName="Larry", lastName="David", Id=5},
                new Employee {firstName="Jerry", lastName="Seinfeld", Id=6},
                new Employee {firstName="Tina", lastName="Fey", Id=7},
                new Employee {firstName="Amy", lastName="Poehler", Id=8},
                new Employee {firstName="Marge", lastName="Simpson", Id=9},
            };

            // creates a new list of the employees with the first name Joe
            List<Employee> joeList = new List<Employee>();

            // a foreach loop that runs through the employee list above, and searches for employees with the first name Joe
            foreach (Employee element in employeeList)
            {
                // if the "element" object that the foreach loop goes through has the property of firstName equal to Joe, it will add that object to the new list.
                if (element.firstName == "Joe")
                {
                    joeList.Add(element);
                }
            }

            //With a lambda function, we achieve the same result, a new list with Joe as the first name
            List<Employee> joeLambdaList = new List<Employee>(employeeList.Where(x => x.firstName == "Joe"));

            // This lambda function creates a new list where the Id is greater than 5 in the employeeList
            List<Employee> bigIdList = new List<Employee>(employeeList.Where(y => y.Id > 5));
        }
    }
}
