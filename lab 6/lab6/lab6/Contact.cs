namespace ProjektKontakty
{
    public class Contact
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;

        public override string ToString() => $"{Id};{Name};{Email}";
    }
}