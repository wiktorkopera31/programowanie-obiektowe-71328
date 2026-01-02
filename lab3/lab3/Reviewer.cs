using System;

namespace Lab3
{
    public class Reviewer : Reader
    {
        public Reviewer(string firstName, string lastName, int age)
            : base(firstName, lastName, age) { }

        public void Wypisz()
        {
            Console.WriteLine($"RECENZJE użytkownika {FirstName}:");
            Random rand = new Random();
            foreach (var book in readBooks)
            {
                book.View();
                Console.WriteLine($"   OCENA: {rand.Next(1, 11)}/10");
            }
        }

        public override void View()
        {
            base.View();
            Wypisz();
        }
    }
}