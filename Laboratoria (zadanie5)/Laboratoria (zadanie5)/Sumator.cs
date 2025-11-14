using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab02
{
    public class Sumator
    {
        // Pole private (po zmianie widoczności)
        private int[] liczby;

        // Konstruktor przyjmujący tablicę
        public Sumator(int[] liczby)
        {
            this.liczby = liczby;
        }

        // Metoda zwracająca sumę wszystkich liczb
        public int Suma()
        {
            int suma = 0;
            foreach (int x in liczby)
                suma += x;
            return suma;
        }

        // Metoda zwracająca sumę liczb podzielnych przez 2
        public int SumaPodziel2()
        {
            int suma = 0;
            foreach (int x in liczby)
                if (x % 2 == 0)
                    suma += x;
            return suma;
        }

        // Zwraca liczbę elementów tablicy
        public int IleElementow()
        {
            return liczby.Length;
        }

        // Wypisuje wszystkie elementy tablicy
        public void WypiszWszystkie()
        {
            Console.WriteLine("Wszystkie elementy:");
            for (int i = 0; i < liczby.Length; i++)
                Console.WriteLine($"[{i}] = {liczby[i]}");
        }

        // Wypisuje elementy z przedziału indeksów
        public void WypiszZakres(int lowIndex, int highIndex)
        {
            Console.WriteLine($"Elementy o indeksach {lowIndex}..{highIndex}:");

            for (int i = 0; i < liczby.Length; i++)
            {
                if (i >= lowIndex && i <= highIndex)
                {
                    Console.WriteLine($"[{i}] = {liczby[i]}");
                }
            }
        }
    }
}