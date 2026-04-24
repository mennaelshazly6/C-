using System;
using System.Collections.Generic;
using System.Text;

namespace _04_Library_Management_System
{
    internal abstract class User
    {
        public string Name { get; set; }
        public  Book[] Display(Library newlib)
        {
           return newlib.Display();
        }
    }
}
