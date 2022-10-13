using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractClassAssignment
{
    interface IQuittable
    {
        void Quit()
        {
            Console.WriteLine("Quitting is an option...");
        }
    }
}
