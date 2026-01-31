using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace ProjektKontakty
{
    public class TxtContactRepository
    {
        private readonly string path = "contacts.txt";

        public void Save(List<Contact> contacts)
        {
            File.WriteAllLines(path, contacts.Select(c => c.ToString())); // [cite: 14]
        }

        public List<Contact> Load()
        {
            if (!File.Exists(path)) return new List<Contact>(); // [cite: 18]

            return File.ReadAllLines(path).Select(line => {
                var p = line.Split(';');
                return new Contact
                {
                    Id = int.Parse(p[0]),
                    Name = p[1],
                    Email = p[2]
                };
            }).ToList();
        }
    }
}