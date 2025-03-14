using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie_3
{
    class Program
    {
        static void Main(string[] args)
        {
            //3. Napisać program wczytujący liczbę całkowitą n (n>2) i wypisujący na ekranie wartość sumy
            //1+2+…+n.Do obliczenia wartości sumy użyj pętli for.
            int n, i, wynik = 0;
            Console.Write("Podaj dowolną liczbę całkowitą n: ");
            n= Convert.ToInt32(Console.ReadLine());
            for (i=1; i <= n; i++)
                wynik += i;
            Console.WriteLine("1+...+{0}={1}", n, wynik);
            Console.ReadKey(true);

        }
    }
}
