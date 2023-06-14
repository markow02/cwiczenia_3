using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_kwota
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj kwotę początkową");
            double kwotaPoczatkowa = double.Parse(Console.ReadLine());

            Console.WriteLine("Podaj oprocentowanie w skali roku (%):");
            double oprocentowanie = double.Parse(Console.ReadLine());

            Console.WriteLine("Podaj liczbę miesięcy oszczędzania");
            int liczbaMiesiecy = int.Parse(Console.ReadLine());

            double podatekBelki = 0.19; //stan na 10.06.23r.
            double oprocentowanieMiesieczne = oprocentowanie / 12 / 100; //oprocentowanie w skali miesiąca
            double kwotaZarobiona = kwotaPoczatkowa * Math.Pow((1 + oprocentowanieMiesieczne), liczbaMiesiecy);
            double kwotaPoOpodatkowaniu = kwotaZarobiona * (1 - podatekBelki);

            Console.WriteLine("Kwota zarobiona: " + kwotaZarobiona);
            Console.WriteLine("Kwota zarobiona: " + kwotaZarobiona);
        }
    }
}
