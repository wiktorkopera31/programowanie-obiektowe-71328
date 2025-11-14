using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorium_2
{
    public class Osoba
    {
        // ===== Pola prywatne =====
        private string imie;
        private string nazwisko;
        private int wiek;

        // ===== Właściwości z walidacją =====
        public string Imie
        {
            get { return imie; }
            set
            {
                if (value.Length < 2)
                    throw new ArgumentException("Imię musi mieć co najmniej 2 znaki.");
                imie = value;
            }
        }

        public string Nazwisko
        {
            get { return nazwisko; }
            set
            {
                if (value.Length < 2)
                    throw new ArgumentException("Nazwisko musi mieć co najmniej 2 znaki.");
                nazwisko = value;
            }
        }

        public int Wiek
        {
            get { return wiek; }
            set
            {
                if (value <= 0)
                    throw new ArgumentException("Wiek musi być liczbą dodatnią.");
                wiek = value;
            }
        }

        // ===== Konstruktor =====
        public Osoba(string imie, string nazwisko, int wiek)
        {
            Imie = imie;
            Nazwisko = nazwisko;
            Wiek = wiek;
        }

        // ===== Metoda =====
        public void WyswietlInformacje()
        {
            Console.WriteLine($"Imię: {Imie}");
            Console.WriteLine($"Nazwisko: {Nazwisko}");
            Console.WriteLine($"Wiek: {Wiek} lat");
        }
    }
}