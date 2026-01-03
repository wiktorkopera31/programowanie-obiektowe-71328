using System;
using System.Collections.Generic;

namespace Lab4_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== SYSTEM ZATRUDNIENIA (Lab 4.1) ===\n");

            Employee emp1 = new Employee("Jan", "Kowalski");
            Employee emp2 = new Employee("Anna", "Nowak", new Position(4500, 10));

            Console.WriteLine("--- STAN POCZĄTKOWY ---");
            Console.WriteLine(emp1);
            Console.WriteLine();
            Console.WriteLine(emp2);

            Console.WriteLine("\n--- ZMIANA KONTRAKTU (Jan Kowalski) ---");
            emp1.ZmienKontrakt(new Position(3800, 5));
            Console.WriteLine(emp1);

            Console.WriteLine("\n--- LISTA PRACOWNIKÓW ---");
            List<Employee> pracownicy = new List<Employee> { emp1, emp2 };

            foreach (var p in pracownicy)
            {
                Console.WriteLine($"{p.LastName}: {p.Pensja():C}");
            }

            Console.ReadKey();
        }
    }
}