using System;

namespace Lab02
{
    class Program
    {
        static void Main(string[] args)
        {
            // Tworzenie obiektów klasy Licz
            Licz licz1 = new Licz(10);
            Licz licz2 = new Licz(50.5);
            Licz licz3 = new Licz(-3);

            // Operacje na licz1
            licz1.Dodaj(5);
            licz1.Odejmij(2);
            licz1.WypiszStan();

            // Operacje na licz2
            licz2.Odejmij(10.5);
            licz2.WypiszStan();

            // Operacje na licz3
            licz3.Dodaj(100);
            licz3.Odejmij(1);
            licz3.WypiszStan();

            Console.WriteLine("Koniec programu.");
        }
    }
}
