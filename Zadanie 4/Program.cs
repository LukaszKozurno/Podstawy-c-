using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie_4
{
    class Program
    {
        static void Main(string[] args)
        {
            //4. Wczytaj dwie liczby naturalne dodatnie n i k. Narysuj z gwiazdek na ekranie prostokąt
            //posiadający n wierszy i k kolumn. Użyj pętli for
            int i, n, a, b;
            Console.Write("Podaj dodatnią liczbę naturalną a: ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Podaj dodatnią liczbę naturalną b: ");
            b = Convert.ToInt32(Console.ReadLine());

            for (i = 1; i <= a; i++)
            {
                for (n = 1; n <= b; n++)
                    Console.Write("*");
                Console.WriteLine("");

            }
            Console.ReadKey(true);
        }
    }
}
