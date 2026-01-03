using System;

namespace Lab4_1
{
    public class Employee
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public IContract Contract { get; private set; }

        public Employee(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
            Contract = new Internship(1000);
        }

        public Employee(string firstName, string lastName, IContract contract)
        {
            FirstName = firstName;
            LastName = lastName;
            Contract = contract;
        }

        public void ZmienKontrakt(IContract nowyKontrakt)
        {
            if (nowyKontrakt != null)
            {
                Contract = nowyKontrakt;
            }
        }

        public decimal Pensja()
        {
            return Contract.Salary();
        }

        public override string ToString()
        {
            return $"Pracownik: {FirstName} {LastName}\n   -> {Contract}\n   -> Do wypłaty: {Pensja():C}";
        }
    }
}