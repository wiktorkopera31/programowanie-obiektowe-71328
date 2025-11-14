using System;

namespace Laboratorium_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Tworzymy konto bankowe
            BankAccount konto = new BankAccount("Jan Kowalski", 1000m);

            // Wyświetlamy saldo początkowe
            Console.WriteLine($"Właściciel: {konto.Wlasciciel}");
            Console.WriteLine($"Saldo początkowe: {konto.Saldo:C}\n");

            // Wpłata
            konto.Wplata(500m);

            // Wypłata
            konto.Wyplata(200m);

            // Sprawdzenie końcowego salda
            Console.WriteLine($"\nSaldo końcowe: {konto.Saldo:C}");

            Console.WriteLine("\nNaciśnij dowolny klawisz, aby zakończyć...");
            Console.ReadKey();
        }
    }
}
