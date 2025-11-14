namespace Lab02
{
    public class Licz
    {
        // Pole private
        private double value;

        // Konstruktor ustawiający początkową wartość
        public Licz(double initial)
        {
            value = initial;
        }

        // Metoda Dodaj
        public void Dodaj(double x)
        {
            value += x;
        }

        // Metoda Odejmij
        public void Odejmij(double x)
        {
            value -= x;
        }

        // Wypisanie stanu obiektu
        public void WypiszStan()
        {
            Console.WriteLine($"Aktualna wartość: {value}");
        }
    }
}