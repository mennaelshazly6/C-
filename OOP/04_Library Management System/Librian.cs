using System;
using System.Collections.Generic;
using System.Text;

namespace _04_Library_Management_System
{
    internal class Librian:User
    {
        public int EmployeeNumber { get; set; }
        public Librian(string name)
        {
            Name=name;
        }
        public void AddBook(Book newBook, Library newLibrary)
        {
            newLibrary.Add(newBook);
        }
        public void RemoveBook (string title,Library newlibrary)
        {
            newlibrary.Remove(title);
        }

    }
}
