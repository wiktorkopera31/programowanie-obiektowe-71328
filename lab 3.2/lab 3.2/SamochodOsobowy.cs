using System;

namespace Zadanie2
{
    
    public class SamochodOsobowy : Samochod
    {
        private double waga;
        private double pojemnoscSilnika;
        public int IloscOsob { get; set; }

        
        public double Waga
        {
            get { return waga; }
            set
            {
                if (value >= 2.0 && value <= 4.5)
                    waga = value;
                else
                {
                    Console.WriteLine("(!) Waga musi być z przedziału 2.0 - 4.5 t. Ustawiono 2.0 t.");
                    waga = 2.0;
                }
            }
        }

        
        public double PojemnoscSilnika
        {
            get { return pojemnoscSilnika; }
            set
            {
                if (value >= 0.8 && value <= 3.0)
                    pojemnoscSilnika = value;
                else
                {
                    Console.WriteLine("(!) Pojemność musi być z przedziału 0.8 - 3.0. Ustawiono 1.0.");
                    pojemnoscSilnika = 1.0;
                }
            }
        }

        
        public SamochodOsobowy() : base()
        {
            Console.WriteLine("--- DANE OSOBOWE ---");

            Console.Write("Podaj Wagę (2.0 - 4.5 t): ");
            double.TryParse(Console.ReadLine(), out double w);
            Waga = w;

            Console.Write("Podaj Pojemność silnika (0.8 - 3.0): ");
            double.TryParse(Console.ReadLine(), out double p);
            PojemnoscSilnika = p;

            Console.Write("Podaj Ilość osób: ");
            int.TryParse(Console.ReadLine(), out int ilosc);
            IloscOsob = ilosc;
        }

        
        public override void WyswietlInfo()
        {
            base.WyswietlInfo(); 
            Console.WriteLine($"   + OSOBOWY: Waga: {Waga}t, Silnik: {PojemnoscSilnika}, Osób: {IloscOsob}");
        }
    }
}