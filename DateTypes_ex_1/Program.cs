using System;

namespace DateTypes_Ex_1
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstName;
            string lastName;
            int age;
            char gender;
            string pesel;
            long id = IdGenerator();

            Console.Write("Imię: ");                  firstName = Console.ReadLine();
            Console.Write("Nazwisko: ");              lastName = Console.ReadLine();
            Console.Write("Wiek: ");                  age = int.Parse(Console.ReadLine());
            Console.Write("Płeć ('m' lub 'k'): ");    gender = char.Parse(Console.ReadLine());
            Console.Write("PESEL: ");                 pesel = Console.ReadLine();

            Console.WriteLine($"\nTWOJE DANE:\n\nImię: {firstName}\nNazwisko: {lastName}\nWiek: {age}\nPłeć: {gender}\nPESEL: {pesel}\nID: {id}\n");
        }
        static long IdGenerator()
        {
            Random random = new Random();

            int number = random.Next(1, 2147483647);

            //return number;
            return random.Next(1, 2147483647);
        }
    }
}
