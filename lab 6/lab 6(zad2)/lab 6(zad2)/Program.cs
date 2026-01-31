using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;

namespace ProjektPopulacja
{
    class Program
    {
        static void Main()
        {
            string jsonString = File.ReadAllText("db.json");
            var data = JsonSerializer.Deserialize<List<PopulationData>>(jsonString);

            while (true)
            {
                Console.Clear();
                Console.WriteLine("=== ANALIZA POPULACJI (Zadanie 2) ===");
                Console.WriteLine("1. Różnice populacji (Zadania stałe)");
                Console.WriteLine("2. Wyświetl populację (Kraj i Rok)");
                Console.WriteLine("3. Różnica populacji (Zakres lat)");
                Console.WriteLine("4. Procentowy wzrost populacji");
                Console.WriteLine("0. Wyjście");
                Console.Write("Wybór: ");

                var choice = Console.ReadLine();
                if (choice == "0") break;

                switch (choice)
                {
                    case "1":
                        Console.WriteLine($"Indie (1970-2000): {ObliczRoznice(data, "India", "1970", "2000")}");
                        Console.WriteLine($"USA (1965-2010): {ObliczRoznice(data, "United States", "1965", "2010")}");
                        Console.WriteLine($"Chiny (1980-2018): {ObliczRoznice(data, "China", "1980", "2018")}");
                        break;
                    case "2":
                        Console.Write("Podaj kraj: "); string k = Console.ReadLine();
                        Console.Write("Podaj rok: "); string r = Console.ReadLine();
                        var entry = data.FirstOrDefault(d => d.Country.Value.Equals(k, StringComparison.OrdinalIgnoreCase) && d.Date == r);
                        Console.WriteLine(entry?.PopulationValue != null ? $"Populacja: {entry.PopulationValue:N0}" : "Brak danych.");
                        break;
                    case "3":
                        Console.Write("Podaj kraj: "); string k2 = Console.ReadLine();
                        Console.Write("Rok od: "); string r1 = Console.ReadLine();
                        Console.Write("Rok do: "); string r2 = Console.ReadLine();
                        Console.WriteLine($"Różnica: {ObliczRoznice(data, k2, r1, r2)}");
                        break;
                    case "4":
                        Console.Write("Podaj rok: "); string rokCel = Console.ReadLine();
                        ObliczWzrostWszystkich(data, rokCel);
                        break;
                }
                Console.WriteLine("\nNaciśnij dowolny klawisz..."); Console.ReadKey();
            }
        }

        static string ObliczRoznice(List<PopulationData> data, string kraj, string rokOd, string rokDo)
        {
            var p1 = data.FirstOrDefault(d => d.Country.Value.Equals(kraj, StringComparison.OrdinalIgnoreCase) && d.Date == rokOd)?.PopulationValue;
            var p2 = data.FirstOrDefault(d => d.Country.Value.Equals(kraj, StringComparison.OrdinalIgnoreCase) && d.Date == rokDo)?.PopulationValue;

            if (p1.HasValue && p2.HasValue) return (p2.Value - p1.Value).ToString("N0");
            return "Brak danych dla podanych parametrów.";
        }

        static void ObliczWzrostWszystkich(List<PopulationData> data, string rok)
        {
            if (!int.TryParse(rok, out int r)) return;
            string rokPoprzedni = (r - 1).ToString();
            var kraje = data.Select(d => d.Country.Value).Distinct().ToList();

            foreach (var k in kraje)
            {
                var popNow = data.FirstOrDefault(d => d.Country.Value == k && d.Date == rok)?.PopulationValue;
                var popPrev = data.FirstOrDefault(d => d.Country.Value == k && d.Date == rokPoprzedni)?.PopulationValue;

                if (popNow.HasValue && popPrev.HasValue && popPrev.Value > 0)
                {
                    double wzrost = (double)(popNow.Value - popPrev.Value) / popPrev.Value * 100;
                    Console.WriteLine($"{k}: {wzrost:F2}% wzrostu względem {rokPoprzedni} r.");
                }
            }
        }
    }
}