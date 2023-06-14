using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_fibonacci
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj liczbę wyrazów do napisania:");
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine("Ciąg Fibonacciego:");
            Fibonacci(n);
        }

        static void Fibonacci(int n)
        {
            int pierwszyWyraz = 0;
            int drugiWyraz = 1;

            if (n >= 1)
            {
                Console.WriteLine(pierwszyWyraz);
            }

            if (n >= 2) //osobny if po to, by program wyświetlał 1 i 2 wyraz a nie 1 lub 2
            {
                Console.WriteLine(drugiWyraz);
            }

            for (int i = 3; i <= n; i++)
            {
                int kolejnyWyraz = pierwszyWyraz + drugiWyraz;
                Console.WriteLine(kolejnyWyraz);

                pierwszyWyraz = drugiWyraz;
                drugiWyraz = kolejnyWyraz;
            }
        }
    }
}
