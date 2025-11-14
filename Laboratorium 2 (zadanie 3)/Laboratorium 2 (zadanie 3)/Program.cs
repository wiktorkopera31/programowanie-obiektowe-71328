using Laboratorium_2__zadanie_3_;
using System;

namespace Laboratorium_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                // Tworzymy studenta
                Student student = new Student("Jan", "Kowalski");

                // Dodajemy kilka ocen
                student.DodajOcene(5);
                student.DodajOcene(4);
                student.DodajOcene(3);

                // Wyświetlamy informacje o studencie
                student.WyswietlInformacje();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Błąd: {ex.Message}");
            }

            Console.WriteLine("Naciśnij dowolny klawisz, aby zakończyć...");
            Console.ReadKey();
        }
    }
}
