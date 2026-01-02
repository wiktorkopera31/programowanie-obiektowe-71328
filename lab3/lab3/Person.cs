using System;

namespace Lab3
{
    public class Person
    {
        private string firstName;
        private string lastName;
        private int age;

        public string FirstName { get { return firstName; } }
        public string LastName { get { return lastName; } }

        public Person(string firstName, string lastName, int age)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.age = age;
        }

        public virtual void View()
        {
            Console.WriteLine($"Osoba: {firstName} {lastName}, Wiek: {age}");
        }
    }
}