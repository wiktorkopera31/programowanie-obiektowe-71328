namespace ZadaniaObiektowe
{
    class Program
    {
        static void Main(string[] args)
        {
            // ===== Zadanie 1 =====
            Console.WriteLine("=== Zadanie 1: Obliczanie delty i pierwiastków ===");
            Console.Write("Podaj a: ");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.Write("Podaj b: ");
            double b = Convert.ToDouble(Console.ReadLine());
            Console.Write("Podaj c: ");
            double c = Convert.ToDouble(Console.ReadLine());
            ObliczTrzymianKwadratowy(a, b, c);

            // ===== Zadanie 2 =====
            Console.WriteLine("\n=== Zadanie 2: Operacje na tablicy liczb całkowitych ===");
            int[] liczby = PobierzTabliceOdUzytkownika(10);
            WyswietlTablice(liczby);
            ObliczStatystykiTablicy(liczby);

            // ===== Zadanie 3 =====
            Console.WriteLine("\n=== Zadanie 3: Liczby od 20 do 0 (z pominięciem kilku) ===");
            WyswietlLiczby();

            // ===== Zadanie 4 =====
            Console.WriteLine("\n=== Zadanie 4: Pętla z break (liczby aż do liczby ujemnej) ===");
            PetlaZNieskonczonoscia();

            // ===== Zadanie 5 =====
            Console.WriteLine("\n=== Zadanie 5: Sortowanie liczb całkowitych ===");
            Console.Write("Podaj, ile liczb chcesz wprowadzić: ");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] dane = PobierzTabliceOdUzytkownika(n);
            Console.WriteLine("Przed sortowaniem:");
            WyswietlTablice(dane);
            SortowanieBabelkowe(dane);
            Console.WriteLine("Po sortowaniu:");
            WyswietlTablice(dane);
        }

        // ===== ZADANIE 1 =====
        static void ObliczTrzymianKwadratowy(double a, double b, double c)
        {
            double delta = b * b - 4 * a * c;
            Console.WriteLine($"Delta = {delta}");

            if (delta < 0)
            {
                Console.WriteLine("Brak pierwiastków rzeczywistych.");
            }
            else if (delta == 0)
            {
                double x0 = -b / (2 * a);
                Console.WriteLine($"Jeden pierwiastek: x0 = {x0}");
            }
            else
            {
                double x1 = (-b - Math.Sqrt(delta)) / (2 * a);
                double x2 = (-b + Math.Sqrt(delta)) / (2 * a);
                Console.WriteLine($"Dwa pierwiastki: x1 = {x1}, x2 = {x2}");
            }
        }

        // ===== ZADANIE 2 =====
        static void ObliczStatystykiTablicy(int[] tab)
        {
            int suma = 0;
            long iloczyn = 1; // używamy long, żeby uniknąć przepełnienia
            int min = tab[0];
            int max = tab[0];

            foreach (int x in tab)
            {
                suma += x;
                iloczyn *= x;
                if (x < min) min = x;
                if (x > max) max = x;
            }

            double srednia = (double)suma / tab.Length;

            Console.WriteLine($"Suma = {suma}");
            Console.WriteLine($"Iloczyn = {iloczyn}");
            Console.WriteLine($"Średnia = {srednia:F2}");
            Console.WriteLine($"Min = {min}");
            Console.WriteLine($"Max = {max}");
        }

        static void WyswietlTablice(int[] tab)
        {
            Console.WriteLine(string.Join(", ", tab));
        }

        static int[] PobierzTabliceOdUzytkownika(int n)
        {
            Console.Write("Czy chcesz losować liczby? (T/N): ");
            string wybor = Console.ReadLine().Trim().ToUpper();

            if (wybor == "T" || wybor == "L")
            {
                Console.Write("Podaj dolną granicę: ");
                int min = Convert.ToInt32(Console.ReadLine());
                Console.Write("Podaj górną granicę: ");
                int max = Convert.ToInt32(Console.ReadLine());
                return LosujTabliceInt(n, min, max);
            }
            else
            {
                int[] arr = new int[n];
                for (int i = 0; i < n; i++)
                {
                    Console.Write($"Podaj liczbę [{i + 1}]: ");
                    arr[i] = Convert.ToInt32(Console.ReadLine());
                }
                return arr;
            }
        }

        // ===== ZADANIE 3 =====
        static void WyswietlLiczby()
        {
            for (int i = 20; i >= 0; i--)
            {
                if (i == 2 || i == 6 || i == 9 || i == 15 || i == 19)
                    continue; // pomijamy te liczby
                Console.Write($"{i} ");
            }
            Console.WriteLine();
        }

        // ===== ZADANIE 4 =====
        static void PetlaZNieskonczonoscia()
        {
            while (true)
            {
                Console.Write("Podaj liczbę całkowitą: ");
                int liczba = Convert.ToInt32(Console.ReadLine());

                if (liczba < 0)
                {
                    Console.WriteLine("Wprowadzono liczbę ujemną – koniec programu.");
                    break; // opuszczenie pętli
                }
                Console.WriteLine($"Podano: {liczba}");
            }
        }

        // ===== ZADANIE 5 =====
        static void SortowanieBabelkowe(int[] tab)
        {
            for (int i = 0; i < tab.Length - 1; i++)
            {
                for (int j = 0; j < tab.Length - 1 - i; j++)
                {
                    if (tab[j] > tab[j + 1])
                    {
                        int temp = tab[j];
                        tab[j] = tab[j + 1];
                        tab[j + 1] = temp;
                    }
                }
            }
        }

        // ===== FUNKCJE LOSUJĄCE =====
        private static int[] LosujTabliceInt(int n, int min, int max)
        {
            var rng = new Random();
            int[] arr = new int[n];

            for (int i = 0; i < n; i++)
                arr[i] = rng.Next(min, max + 1);

            Console.WriteLine("Wylosowano liczby:");
            WyswietlTablice(arr);

            return arr;
        }
    }
}
