using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_funkcja_ex
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj wartość x:");
            double x = double.Parse(Console.ReadLine());

            Console.WriteLine("Podaj liczbę wyrazów (n):");
            int n = int.Parse(Console.ReadLine());

            double wynik = SzeregTaylora(x, n);

            Console.WriteLine($"Szacowana wartość e^{x}: {wynik}");
        }

        static double SzeregTaylora(double x, int n)
        {
            double wynik = 1.0; // Pierwszy wyraz (i=0) to 1

            double potegaX = 1.0; // x^0 = 1
            double silnia = 1.0; // 0! = 1

            for (int i = 1; i <= n; i++)
            {
                potegaX *= x; // x^i
                silnia *= i; // i!

                double wyraz = potegaX / silnia; 

                wynik += wyraz; 
            }

            return wynik;
        }
    }
}
