using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8_zgadywanie
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Pomyśl liczbę z przedziału 1-20.");
            Console.WriteLine("Naciśnij dowolny klawisz, gdy będziesz gotowy.");
            Console.ReadKey();
            Console.WriteLine("Zgaduję...");

            int dolnyPrzedzial = 1;
            int gornyPrzedzial = 20;

            while (true)
            {
                int propozycja = (dolnyPrzedzial + gornyPrzedzial) / 2;

                Console.WriteLine("Czy pomyślana liczba to " + propozycja + "?");
                Console.WriteLine("Wprowadź odpowiedź:");
                int odpowiedz = int.Parse(Console.ReadLine());

                if (odpowiedz < 0)
                {
                    gornyPrzedzial = propozycja - 1;
                }
                else if (odpowiedz > 0)
                {
                    dolnyPrzedzial = propozycja + 1;
                }
                else
                {
                    Console.WriteLine("Odgadłem! Pomyślana liczba to " + propozycja + ".");
                    break;
                }

                if (dolnyPrzedzial > gornyPrzedzial)
                {
                    Console.WriteLine("Nie mogę odgadnąć liczby. Sprawdź, czy odpowiedziałeś poprawnie.");
                    break;
                }
            }
        }
    }
}
