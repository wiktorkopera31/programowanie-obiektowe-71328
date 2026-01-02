using System;

namespace Zadanie2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== START ZADANIA 2 ===\n");

            
            Console.WriteLine(">>> KROK 1: Utwórz Samochód Osobowy <<<");
            SamochodOsobowy osobo1 = new SamochodOsobowy();

            
            Console.WriteLine("\n>>> KROK 2: Utwórz Zwykły Samochód (Ręcznie) <<<");
            Samochod auto1 = new Samochod();

            
            Console.WriteLine("\n>>> KROK 3: Utwórz Zwykły Samochód (Automatycznie) <<<");
            Samochod auto2 = new Samochod("Toyota", "Yaris", "Hatchback", "Biały", 2021, 45000);

            
            Console.WriteLine("\n\n================ PODSUMOWANIE ================");

            Console.WriteLine("[1] Twój Samochód Osobowy:");
            osobo1.WyswietlInfo();
            Console.WriteLine("---------------------------------------------");

            Console.WriteLine("[2] Twój Zwykły Samochód:");
            auto1.WyswietlInfo();
            Console.WriteLine("---------------------------------------------");

            Console.WriteLine("[3] Samochód zdefiniowany w kodzie:");
            auto2.WyswietlInfo();

            Console.WriteLine("\nNaciśnij Enter, aby zamknąć...");
            Console.ReadLine();
        }
    }
}