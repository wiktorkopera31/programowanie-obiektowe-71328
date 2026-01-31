using System.IO;
using System.Collections.Generic;
using System.Text.Json;

namespace ProjektKontakty
{
    public class JsonContactRepository
    {
        private readonly string path = "contacts.json";

        public void Save(List<Contact> contacts)
        {
            var options = new JsonSerializerOptions { WriteIndented = true };
            File.WriteAllText(path, JsonSerializer.Serialize(contacts, options));
        }

        public List<Contact> Load()
        {
            if (!File.Exists(path)) return new List<Contact>();
            return JsonSerializer.Deserialize<List<Contact>>(File.ReadAllText(path)) ?? new List<Contact>();
        }
    }
}