using System;
using System.Collections.Generic;

namespace Lab3
{
    public class Reader : Person
    {
        // Lista jest protected, aby Reviewer miał do niej dostęp
        protected List<Book> readBooks = new List<Book>();

        public Reader(string firstName, string lastName, int age)
            : base(firstName, lastName, age) { }

        public void AddBook(Book book)
        {
            readBooks.Add(book);
        }

        public void ViewBook()
        {
            Console.WriteLine($"--- Książki przeczytane przez {FirstName}: ---");
            foreach (var book in readBooks)
            {
                book.View();
            }
        }

        public override void View()
        {
            base.View(); // Wyświetla dane osoby
            ViewBook();  // Wyświetla listę książek
        }
    }
}