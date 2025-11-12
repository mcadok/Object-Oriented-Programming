using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1zad2
{
    internal class Zadanie2
    {
        public void Run()
        {
            double[] liczby = new double[10];

            Console.WriteLine("wprowadz 10 liczb:");
            for (int i = 0; i < 10; i++)
            {
                Console.Write($"liczba {i + 1}: ");
                liczby[i] = Convert.ToDouble(Console.ReadLine());
            }

            double suma = 0;
            double iloczyn = 1;
            double min = liczby[0];
            double max = liczby[0];

            foreach (double liczba in liczby)
            {
                suma += liczba;
                iloczyn *= liczba;
                if (liczba < min) min = liczba;
                if (liczba > max) max = liczba;
            }

            double srednia = suma / liczby.Length;

            Console.WriteLine("\nwyniki:");
            Console.WriteLine($"suma: {suma}");
            Console.WriteLine($"iloczyn: {iloczyn}");
            Console.WriteLine($"srednia: {srednia:F2}");
            Console.WriteLine($"wartosc minimalna: {min}");
            Console.WriteLine($"wartosc maksymalna: {max}");
        }
    }
}
