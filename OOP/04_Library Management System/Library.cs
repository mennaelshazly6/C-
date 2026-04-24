using System;
using System.Collections.Generic;
using System.Text;

namespace _04_Library_Management_System
{
    internal  class Library
    {
        private Book[] Books = new Book[100];
        int CurrentBookCounter = 0;
        private Book[] BorrowedBooks = new Book[50];
        int CurrentBorrowedBookCounter = 0;

        public Book[] Display()
        {
            for (int i = 0; i < CurrentBookCounter; i++) 
            {
                Console.WriteLine($"Book Name:{Books[i].Title} , Book Author:{Books[i].Author}, Book Year{Books[i].Year}");
            }
            return Books;
        }
        public void Add(Book newBook)
        {
            if (CurrentBookCounter < Books.Length)
            {
                Books[CurrentBookCounter] = newBook;
                CurrentBookCounter++;
            }
            else
            {
                Console.WriteLine("The Library is Full ");
            }
        }
        public void Remove(string title)
        {
            for (int i = 0; i <CurrentBookCounter; i++)
            {
                if (Books[i] != null && Books[i].Title == title)
                {
                    Books[i] = null;
                    Console.WriteLine("Book removed");
                    CurrentBookCounter--;

                    return;
                }
            }

            Console.WriteLine("Book not found");
        }
        public void Borrow(string title)
        {
            for(int i = 0; i < CurrentBookCounter; i++)
            {
                if (Books[i] != null && Books[i].Title == title)
                {
                    BorrowedBooks[i] = Books[i];
                    CurrentBorrowedBookCounter++;
                    Console.WriteLine("Book Borrowed Successfully");
                }
                Console.WriteLine("Book Not found");
            }
        }
    }
}
