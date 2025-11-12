using System;

namespace lab2zadania
{
    internal class Zadanie2
    {
        public void Run()
        {
            BankAccount konto = new BankAccount("Jan Kowalski", 1000);
            konto.Wplata(500);
            konto.Wyplata(200);
            konto.Wyplata(2000); // brak środków
            Console.WriteLine("saldo: " + konto.Saldo);
        }
    }

    public class BankAccount
    {
        private decimal saldo;

        public decimal Saldo
        {
            get { return saldo; }
        }

        public string Wlasiciel { get; set; }

        public BankAccount(string wlasiciel, decimal poczatkoweSaldo = 0)
        {
            Wlasiciel = wlasiciel;
            saldo = poczatkoweSaldo;
        }

        public void Wplata(decimal kwota)
        {
            if (kwota > 0)
            {
                saldo += kwota;
                Console.WriteLine("wplata: " + kwota + ", nowe saldo: " + saldo);
            }
        }

        public void Wyplata(decimal kwota)
        {
            if (kwota > 0 && kwota <= saldo)
            {
                saldo -= kwota;
                Console.WriteLine("wyplata: " + kwota + ", nowe saldo: " + saldo);
            }
            else
            {
                Console.WriteLine("nie mozna wyplacic " + kwota + ". brak srodkow lub bledna kwota.");
            }
        }
    }
}
