using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorium_2__zadanie_3_
{
    public class Student
    {
        // ===== Pola prywatne =====
        private List<int> oceny; // przechowuje oceny studenta

        // ===== Właściwości =====
        public string Imie { get; set; }
        public string Nazwisko { get; set; }

        // Właściwość obliczająca średnią ocen
        public double SredniaOcen
        {
            get
            {
                if (oceny.Count == 0) return 0; // brak ocen → średnia = 0
                return oceny.Average();
            }
        }

        // ===== Konstruktor =====
        public Student(string imie, string nazwisko)
        {
            if (string.IsNullOrWhiteSpace(imie) || imie.Length < 2)
                throw new ArgumentException("Imię musi mieć co najmniej 2 znaki.");
            if (string.IsNullOrWhiteSpace(nazwisko) || nazwisko.Length < 2)
                throw new ArgumentException("Nazwisko musi mieć co najmniej 2 znaki.");

            Imie = imie;
            Nazwisko = nazwisko;
            oceny = new List<int>();
        }

        // ===== Metoda do dodawania oceny =====
        public void DodajOcene(int ocena)
        {
            if (ocena < 2 || ocena > 5) // typowe oceny szkolne 2-5
                throw new ArgumentException("Ocena musi być w przedziale 2-5.");
            oceny.Add(ocena);
        }

        // ===== Metoda do wyświetlania informacji o studencie =====
        public void WyswietlInformacje()
        {
            Console.WriteLine($"Student: {Imie} {Nazwisko}");
            Console.WriteLine($"Oceny: {(oceny.Count > 0 ? string.Join(", ", oceny) : "brak")}");
            Console.WriteLine($"Średnia ocen: {SredniaOcen:F2}\n");
        }
    }
}