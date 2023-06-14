using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_silnia
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj liczbę x:");
            int x = int.Parse(Console.ReadLine());

            int n = sprawdzSilnie(x);

            if (n != -1)
            {
                Console.WriteLine($"{x} jest silnią liczby {n}.");
            }
            else
            {
                Console.WriteLine($"{x} nie jest silnią żadnej liczby.");
            }
        }

        static int sprawdzSilnie(int x)
        {
            int n = 0;
            int silnia = 1;

            while (silnia <= x)
            {
                n++;
                silnia *= n;

                if (silnia == x)
                {
                    return n;
                }
            }

            return -1; // x nie jest silnią żadnej liczby
        }
    }
}
