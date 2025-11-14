using System;

namespace Laboratorium_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("=== Tworzenie obiektu klasy Osoba ===");
                Console.Write("Podaj imię: ");
                string imie = Console.ReadLine();

                Console.Write("Podaj nazwisko: ");
                string nazwisko = Console.ReadLine();

                Console.Write("Podaj wiek: ");
                int wiek = Convert.ToInt32(Console.ReadLine());

                Osoba osoba1 = new Osoba(imie, nazwisko, wiek);

                Console.WriteLine("\n=== Dane osoby ===");
                osoba1.WyswietlInformacje();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"\nBłąd: {ex.Message}");
            }

            Console.WriteLine("\nNaciśnij dowolny klawisz, aby zakończyć...");
            Console.ReadKey();

        }
    }
}
