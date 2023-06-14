using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_potegowanie
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj podstawę:");
            int podstawa = int.Parse(Console.ReadLine()); // Wczytanie podstawy od użytkownika

            Console.WriteLine("Podaj wykładnik:");
            int wykladnik = int.Parse(Console.ReadLine()); // Wczytanie wykładnika od użytkownika

            int wynik = Potegowanie(podstawa, wykladnik); // Wywołanie funkcji do potęgowania
            Console.WriteLine("Wynik potęgowania " + podstawa + "^" + wykladnik + "=" + wynik); // Wyświetlenie wyniku

        }

        public static int Potegowanie(int podstawa, int wykladnik)
        {
            if (wykladnik == 0)
            {
                return 1; // Jeśli wykładnik wynosi 0, zwracamy 1
            }

            int wynik = 1;

            for (int i = 0; i < wykladnik; i++)
            {
                wynik *= podstawa; // Pomnożenie podstawy przez siebie tyle razy, ile wynosi wykładnik
            }

            return wynik; // Zwracamy obliczony wynik potęgowania
        }

    }
}