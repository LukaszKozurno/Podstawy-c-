using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie_5._1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Wczytaj liczbę naturalną n (n>1). Narysuj na ekranie z gwiazdek trójkąt prostokątny. Użyj
            //pętli for. Przykładowo dla n=3 narysowany trójkąt powinien wyglądać:
            int a, b, c;
            Console.Write("Podaj dodatnią liczbę naturalną: ");
            c= Convert.ToInt32(Console.ReadLine());
            for (a=1; a<=c; a++)
            {
                for (b=1; b<=a; b++)
                    Console.Write("*");
                Console.WriteLine("");
            }
            Console.ReadKey(true);

        }
    }
}
