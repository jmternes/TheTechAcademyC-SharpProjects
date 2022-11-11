using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace FinalChallenge
{
    class Program
    {
        static void Main(string[] args)
        {

            using (var ctx = new SchoolContext())
            {
                var student = new Student()
                {
                    StudentId = 0,
                    StudentName = "Jane Doe",
                    DateOfBirth = new DateTime(1993, 4, 22),
                    Height = 53,
                    Weight = 152
                };

                ctx.Students.Add(student);
                ctx.SaveChanges();
            }
        }
    }
}
