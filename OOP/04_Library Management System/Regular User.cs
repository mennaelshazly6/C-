using System;
using System.Collections.Generic;
using System.Text;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace _04_Library_Management_System
{
    internal class Regular_User:User
    {
        Library_Card card {  get; set; }
        public void BorrowBook(string title,Library l )
        {
            l.Borrow(title);
        }
    }
}
