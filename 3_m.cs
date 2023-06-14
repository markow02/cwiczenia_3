using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_m
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n, k;

            do
            {
                Console.WriteLine("Podaj liczbę n (większą lub równą 5):");
                n = int.Parse(Console.ReadLine());
            } while (n < 5);

            do
            {
                Console.WriteLine("Podaj liczbę k (większą lub równą 5):");
                k = int.Parse(Console.ReadLine());
            } while (k < 5);

            int wynik = obliczM(n, k);
            Console.WriteLine("m = " + wynik);
        }

        static int obliczM(int n, int k)
        {
            int silniaN = 1;
            int silniaK = 1;

            for(int i = 1; i <= n; i++)
            {
                silniaN *= i;
            }

            for(int i = 1; i <= k; i++)
            {
                silniaK *= i;
            }

            int m = (silniaN - silniaK) / silniaK;
            return m;
        }
    }
}
