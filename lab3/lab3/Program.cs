using System;
using System.Collections.Generic;

namespace Lab3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== SYSTEM BIBLIOTECZNY ===");

            // 1. Autorzy
            Person author1 = new Person("Adam", "Mickiewicz", 57);
            Person author2 = new Person("J.K.", "Rowling", 55);

            // 2. Książki
            Book b1 = new Book("Pan Tadeusz", author1, new DateTime(1834, 6, 28));
            AdventureBook b2 = new AdventureBook("Harry Potter", author2, new DateTime(1997, 6, 26), "Hogwart");
            DocumentaryBook b3 = new DocumentaryBook("Życie Adama", author1, new DateTime(2000, 1, 1), "Biografia");

            // 3. Czytelnik
            Reader r1 = new Reader("Jan", "Kowalski", 22);
            r1.AddBook(b1);
            r1.AddBook(b2);

            // 4. Recenzent
            Reviewer rev1 = new Reviewer("Anna", "Nowak", 30);
            rev1.AddBook(b2);
            rev1.AddBook(b3);

            // 5. Lista wspólna
            List<Person> people = new List<Person> { r1, rev1 };

            foreach (Person p in people)
            {
                Console.WriteLine("\n-------------------------------");
                p.View();
            }

            Console.ReadKey();
        }
    }
}