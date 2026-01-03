using System;

namespace Lab4_1
{
    public class Internship : IContract
    {
        public decimal StawkaMiesieczna { get; private set; }

        public Internship(decimal stawka)
        {
            StawkaMiesieczna = stawka;
        }

        public decimal Salary()
        {
            return StawkaMiesieczna;
        }

        public override string ToString()
        {
            return $"Umowa: Staż, Stawka: {StawkaMiesieczna:C}";
        }
    }
}