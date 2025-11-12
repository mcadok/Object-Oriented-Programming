using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1zad1
{
    internal class Zadanie1
    {
        public void Run()
        {
            Console.WriteLine("program na podstawie danych a,b i c oblicza x1 i x2");
            Console.WriteLine("podaj a: ");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("podaj b: ");
            double b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("podaj c: ");
            double c = Convert.ToDouble(Console.ReadLine());

            if (a == 0)
            {
                Console.WriteLine("a=0 - nie jest to rownanie kwadratowe");
                return;
            }
            double delta = (b * b) - (4 * a * c);
            Console.WriteLine("delta = " + delta);
            if (delta < 0)
            {
                Console.WriteLine("brak wynikow");
            }
            else if(delta ==0)
            {
                double x = (-b) / (2 * a);
                Console.WriteLine("jest 1 rozwiązanie x = " + x);

            }
            else
            {
                double x1 = (-b - Math.Sqrt(delta)) / (2 * a);
                double x2 = (-b + Math.Sqrt(delta)) / (2 * a);

                Console.WriteLine("sa 2 rozwiazania x1 = " + x1 + " oraz x2 = " + x2);
            }
        }
    }
}
