using System;
using System.Collections.Generic;

namespace Lab5_Zadanie1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== KALKULATOR ===");

            List<double> historia = new List<double>();
            bool kontynuuj = true;

            while (kontynuuj)
            {
                Console.WriteLine("\n-------------------------------------------");
                try
                {
                    Console.Write("Podaj pierwszą liczbę: ");
                    double a = double.Parse(Console.ReadLine());

                    Console.Write("Podaj drugą liczbę: ");
                    double b = double.Parse(Console.ReadLine());

                    Console.WriteLine("Wybierz operację:");
                    Console.WriteLine("0 - Dodawanie");
                    Console.WriteLine("1 - Odejmowanie");
                    Console.WriteLine("2 - Mnożenie");
                    Console.WriteLine("3 - Dzielenie");
                    Console.Write("Twój wybór: ");

                    string wybor = Console.ReadLine();
                    Operacja op = (Operacja)Enum.Parse(typeof(Operacja), wybor, true);

                    double wynik = 0;

                    switch (op)
                    {
                        case Operacja.Dodawanie:
                            wynik = a + b;
                            break;
                        case Operacja.Odejmowanie:
                            wynik = a - b;
                            break;
                        case Operacja.Mnozenie:
                            wynik = a * b;
                            break;
                        case Operacja.Dzielenie:
                            if (b == 0)
                            {
                                throw new DivideByZeroException();
                            }
                            wynik = a / b;
                            break;
                        default:
                            Console.WriteLine("Nieznana operacja.");
                            continue;
                    }

                    Console.WriteLine($"WYNIK: {wynik}");
                    historia.Add(wynik);
                }
                catch (FormatException)
                {
                    Console.WriteLine("BŁĄD: Wprowadzono nieprawidłowe dane! Oczekiwano liczby.");
                }
                catch (DivideByZeroException)
                {
                    Console.WriteLine("BŁĄD: Nie można dzielić przez zero!");
                }
                catch (ArgumentException)
                {
                    Console.WriteLine("BŁĄD: Wybrano nieprawidłową operację.");
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Wystąpił nieoczekiwany błąd: {ex.Message}");
                }

                Console.WriteLine("\nCzy chcesz wyświetlić historię wyników? (t/n)");
                if (Console.ReadLine().ToLower() == "t")
                {
                    Console.Write("Historia: ");
                    foreach (var h in historia)
                    {
                        Console.Write($"{h}; ");
                    }
                    Console.WriteLine();
                }

                Console.WriteLine("Czy chcesz wykonać kolejne działanie? (t/n)");
                string decyzja = Console.ReadLine().ToLower();
                if (decyzja != "t" && decyzja != "tak")
                {
                    kontynuuj = false;
                }
            }
        }
    }
}