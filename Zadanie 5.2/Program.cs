using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie_5._2
{
    class Program
    {
        static int liczba_pierwsza(int liczba)
        {
            //Napisz funkcję, która sprawdza czy jej argument jest liczbą pierwszą. Jako wartość funkcja
            //powinna zwracać 1 dla liczb pierwszych i 0 dla pozostałych liczb.Przetestuj działanie
            //utworzonej funkcji.
            int i;
            for (i = 1; i <= liczba / 2; i++)
                if (liczba % i == 0)
                    return 0;
            return 1;
            static void Main(string[] args)
            {
                Console.WriteLine("Czy liczba 20 jest liczbą pierwszą: {0}", liczba_pierwsza(20));
                Console.WriteLine("Czy liczba 23 jest liczbą pierwszą: {0}", liczba_pierwsza(23));
                Console.ReadKey(true);
            }


        }
    }
}
