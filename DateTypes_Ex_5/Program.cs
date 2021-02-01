using System;

namespace DateTypes_Ex_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("PLEASE INPUT YOUR DATA BELOW");
            Console.Write("Imię: ");
            string firstName = Console.ReadLine();
            Console.Write("Nazwisko: ");
            string lastName = Console.ReadLine();
            Console.Write("Wiek: ");
            int age = int.Parse(Console.ReadLine());
            Console.Write("Numer telefonu: ");
            string telNumber = Console.ReadLine();
            Console.Write("E-mail: ");
            string email = Console.ReadLine();
            Console.Write("Wzrost: ");
            float heigh = float.Parse(Console.ReadLine());
            Console.Write("Waga: ");
            float weigh = float.Parse(Console.ReadLine());

        }
    }
}
