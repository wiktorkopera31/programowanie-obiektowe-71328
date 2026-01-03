using System;

namespace Lab4_1
{
    public class Position : IContract
    {
        public decimal MonthlyRate { get; set; }
        public int Overtime { get; set; }

        public Position(decimal rate, int overtime)
        {
            MonthlyRate = rate;
            Overtime = overtime;
        }

        public decimal Salary()
        {
            return MonthlyRate + (Overtime * (MonthlyRate / 60m));
        }

        public override string ToString()
        {
            return $"Umowa: Etat, Podstawa: {MonthlyRate:C}, Nadgodziny: {Overtime}";
        }
    }
}