using System;

using lab1zad1;
using lab1zad2;
using lab1zad3;

class Program
{
    static void Main(string[] args)
    {
        
        Zadanie1 zad1 = new Zadanie1();
        zad1.Run();

        Zadanie2 zad2 = new Zadanie2();
        zad2.Run();

        Zadanie3 zad3 = new Zadanie3();
        zad3.Run();

        Console.WriteLine("\nkoniec programu");
    }
}
