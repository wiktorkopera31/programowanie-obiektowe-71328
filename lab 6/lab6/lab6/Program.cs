using System;
using System.Collections.Generic;
using System.Linq;

namespace ProjektKontakty
{
    class Program
    {
        static void Main()
        {
            var txtRepo = new TxtContactRepository();
            var jsonRepo = new JsonContactRepository();
            List<Contact> contacts = jsonRepo.Load(); // Wczytuje przy starcie

            while (true)
            {
                Console.Clear();
                Console.WriteLine("1-Lista, 2-Dodaj, 3-Zapisz TXT, 4-Zapisz JSON, 5-Wyjście");
                var choice = Console.ReadLine();

                if (choice == "1")
                {
                    contacts.ForEach(c => Console.WriteLine($"[{c.Id}] {c.Name} ({c.Email})"));
                    Console.WriteLine("Naciśnij klawisz..."); Console.ReadKey();
                }
                else if (choice == "2")
                {
                    var c = new Contact { Id = contacts.Count > 0 ? contacts.Max(x => x.Id) + 1 : 1 };
                    Console.Write("Imię: "); c.Name = Console.ReadLine() ?? "";
                    Console.Write("Email: "); c.Email = Console.ReadLine() ?? "";
                    contacts.Add(c);
                }
                else if (choice == "3") { txtRepo.Save(contacts); Console.WriteLine("Zapisano TXT!"); System.Threading.Thread.Sleep(1000); }
                else if (choice == "4") { jsonRepo.Save(contacts); Console.WriteLine("Zapisano JSON!"); System.Threading.Thread.Sleep(1000); }
                else if (choice == "5") break;
            }
        }
    }
}