using System;

namespace Zadanie2
{
    public class Samochod
    {
        
        public string Marka { get; set; }
        public string Model { get; set; }
        public string Nadwozie { get; set; }
        public string Kolor { get; set; }
        public int RokProdukcji { get; set; }

        
        private int przebieg;

        
        public int Przebieg
        {
            get { return przebieg; }
            set
            {
                if (value < 0)
                {
                    Console.WriteLine("(!) Przebieg nie może być ujemny. Ustawiono 0.");
                    przebieg = 0;
                }
                else
                {
                    przebieg = value;
                }
            }
        }

        
        public Samochod()
        {
            Console.WriteLine("\n--- NOWY SAMOCHÓD (Wprowadzanie danych) ---");
            Console.Write("Podaj Markę: ");
            Marka = Console.ReadLine();

            Console.Write("Podaj Model: ");
            Model = Console.ReadLine();

            Console.Write("Podaj Nadwozie: ");
            Nadwozie = Console.ReadLine();

            Console.Write("Podaj Kolor: ");
            Kolor = Console.ReadLine();

            Console.Write("Podaj Rok produkcji: ");
            int.TryParse(Console.ReadLine(), out int rok);
            RokProdukcji = rok;

            Console.Write("Podaj Przebieg: ");
            int.TryParse(Console.ReadLine(), out int p);
            Przebieg = p; // To uruchomi walidację w setterze
        }

        
        public Samochod(string marka, string model, string nadwozie, string kolor, int rok, int przebieg)
        {
            Marka = marka;
            Model = model;
            Nadwozie = nadwozie;
            Kolor = kolor;
            RokProdukcji = rok;
            Przebieg = przebieg;
        }

        
        public virtual void WyswietlInfo()
        {
            Console.WriteLine($"POJAZD: {Marka} {Model} | Nadwozie: {Nadwozie} | Kolor: {Kolor} | Rok: {RokProdukcji} | Przebieg: {Przebieg} km");
        }
    }
}