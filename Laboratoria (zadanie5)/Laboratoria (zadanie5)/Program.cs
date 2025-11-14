using System;

namespace Lab02
{
    class Program
    {
        static void Main(string[] args)
        {
            // Tworzymy tablicę
            int[] dane = { 1, 2, 5, 10, 17, 22, 100 };

            // Tworzymy obiekt klasy Sumator
            Sumator s = new Sumator(dane);

            // Testowanie metod
            Console.WriteLine("Suma wszystkich: " + s.Suma());
            Console.WriteLine("Suma podzielnych przez 2: " + s.SumaPodziel2());
            Console.WriteLine("Liczba elementów: " + s.IleElementow());

            Console.WriteLine();
            s.WypiszWszystkie();

            Console.WriteLine();
            s.WypiszZakres(2, 10); // pokazuje zakres + ignoruje indeksy spoza tablicy

            Console.WriteLine("\nKoniec programu.");
        }
    }
}
