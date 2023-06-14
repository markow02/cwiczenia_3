using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_pary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj liczbę n:");
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine("Pary liczb o sumie równiej " + n + ":");
            WypiszParyLiczb(n);
        }

        static void WypiszParyLiczb(int n)
        {
            for (int i = 1; i <= n / 2; i++)
            {
                int drugaLiczba = n - i;

                Console.WriteLine("(" + i + ", " + drugaLiczba + ")");
            }
        }
    }
}
