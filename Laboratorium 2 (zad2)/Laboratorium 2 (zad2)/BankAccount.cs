using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorium_2
{
    public class BankAccount
    {
        // ===== Właściwości =====
        public string Wlasciciel { get; set; }
        public decimal Saldo { get; private set; } // tylko do odczytu z zewnątrz

        // ===== Konstruktor =====
        public BankAccount(string wlasciciel, decimal saldoPoczatkowe)
        {
            if (saldoPoczatkowe < 0)
                throw new ArgumentException("Saldo początkowe nie może być ujemne.");

            Wlasciciel = wlasciciel;
            Saldo = saldoPoczatkowe;
        }

        // ===== Metody =====
        public void Wplata(decimal kwota)
        {
            if (kwota <= 0)
                throw new ArgumentException("Kwota wpłaty musi być dodatnia.");

            Saldo += kwota;
            Console.WriteLine($"Wpłacono {kwota:C}. Saldo: {Saldo:C}");
        }

        public void Wyplata(decimal kwota)
        {
            if (kwota <= 0)
            {
                Console.WriteLine("Kwota wypłaty musi być dodatnia.");
                return;
            }

            if (kwota > Saldo)
            {
                Console.WriteLine("Brak wystarczających środków na koncie.");
                return;
            }

            Saldo -= kwota;
            Console.WriteLine($"Wypłacono {kwota:C}. Saldo: {Saldo:C}");
        }
    }
}