using System;

namespace Lab3
{
    public class Book
    {
        protected string title;
        protected Person author;
        protected DateTime releaseDate;

        public Book(string title, Person author, DateTime releaseDate)
        {
            this.title = title;
            this.author = author;
            this.releaseDate = releaseDate;
        }

        public virtual void View()
        {
            Console.WriteLine($"Tytuł: '{title}', Autor: {author.FirstName} {author.LastName}, Data: {releaseDate.ToShortDateString()}");
        }
    }

    // Klasy dziedziczące po Book (AdventureBook i DocumentaryBook)
    public class AdventureBook : Book
    {
        private string setting;

        public AdventureBook(string title, Person author, DateTime releaseDate, string setting)
            : base(title, author, releaseDate)
        {
            this.setting = setting;
        }

        public override void View()
        {
            base.View();
            Console.WriteLine($"   -> Gatunek: Przygodowa, Miejsce akcji: {setting}");
        }
    }

    public class DocumentaryBook : Book
    {
        private string topic;

        public DocumentaryBook(string title, Person author, DateTime releaseDate, string topic)
            : base(title, author, releaseDate)
        {
            this.topic = topic;
        }

        public override void View()
        {
            base.View();
            Console.WriteLine($"   -> Gatunek: Dokument, Temat: {topic}");
        }
    }
}