using System;

namespace lab2zadania
{
    internal class Zadanie1
    {
        public void Run()
        {
            try
            {
                Osoba osoba1 = new Osoba("Jan", "Kowalski", 25);
                osoba1.WyswietlInformacje();

                Osoba osoba2 = new Osoba("A", "Nowak", 30); 
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine("blad: " + ex.Message);
            }

            try
            {
                Osoba osoba3 = new Osoba("Anna", "B", -5); 
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine("blad: " + ex.Message);
            }
        }
    }

    public class Osoba
    {
        private string imie;
        private string nazwisko;
        private int wiek;

        public string Imie
        {
            get { return imie; }
            set
            {
                if (string.IsNullOrWhiteSpace(value) || value.Length < 2)
                    throw new ArgumentException("imie musi miec co najmniej 2 znaki");
                imie = value;
            }
        }

        public string Nazwisko
        {
            get { return nazwisko; }
            set
            {
                if (string.IsNullOrWhiteSpace(value) || value.Length < 2)
                    throw new ArgumentException("nazwisko musi miec co najmniej 2 znaki");
                nazwisko = value;
            }
        }

        public int Wiek
        {
            get { return wiek; }
            set
            {
                if (value < 0)
                    throw new ArgumentException("wiek musi byc liczba dodatnia");
                wiek = value;
            }
        }

        public Osoba(string imie, string nazwisko, int wiek)
        {
            Imie = imie;
            Nazwisko = nazwisko;
            Wiek = wiek;
        }

        public void WyswietlInformacje()
        {
            Console.WriteLine($"imie: {Imie}, nazwisko: {Nazwisko}, wiek: {Wiek}");
        }
    }
}
