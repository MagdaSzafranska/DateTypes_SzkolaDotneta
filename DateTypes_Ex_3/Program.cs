using System;

namespace DateTypes_Ex_3
{
    class Program
    {
        static void Main(string[] args)
        {
            //PrzekatnaProstokata();

            Console.Write("Szerokość: ");
            double a = double.Parse(Console.ReadLine());
            Console.Write("Wysokość: ");
            double b = double.Parse(Console.ReadLine());

            double przekatna = Math.Sqrt(Math.Pow(a, 2) + Math.Pow(b, 2));
            Console.WriteLine("\nPrzekątna prostokąta o wymiarach {0} x {1} wynosi: {2}.", a, b, przekatna);

        }
        static void PrzekatnaProstokata()
        {
            double szerokosc, wysokosc;
            double przekatna;

            Console.Write("Podaj szerokość prostokąta: ");
            szerokosc = double.Parse(Console.ReadLine());
            Console.Write("Podaj wysokość prostokąta: ");
            wysokosc = double.Parse(Console.ReadLine());

            przekatna = Math.Sqrt((szerokosc * szerokosc) + (wysokosc * wysokosc));

            Console.WriteLine($"\nPrzekątna prostokąta o wymiarach {szerokosc} x {wysokosc} wynosi: {przekatna}\n");

        }
    }
}
