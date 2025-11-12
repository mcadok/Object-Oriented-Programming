using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1zad3
{
    internal class Zadanie3
    {
        public void Run()
        {
            Console.WriteLine("liczby od 20 do 0 (bez 2,6,9,15,19):");

            for (int i = 20; i >= 0; i--)
            {
                if (i == 2 || i == 6 || i == 9 || i == 15 || i == 19)
                {
                    continue;
                }
                Console.Write(i + " ");
            }

            Console.WriteLine();
        }
    }
}
