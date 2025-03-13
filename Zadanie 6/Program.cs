using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie_6
{
    class Program
    {
        static void Main(string[] args)
        {
            //6. Napisać program wczytujący numer miesiąca (od 1 do 12) i wypisujący na ekranie nazwę tego
            //miesiąca.Użyj instrukcji wyboru switch.
            int miesiac;
            Console.Write("Podaj numer miesiąca: ");
            miesiac = Convert.ToInt32(Console.ReadLine());
            switch(miesiac)
            {
                case 1: Console.WriteLine("Styczeń"); break;
                case 2: Console.WriteLine("Styczeń"); break;
                case 3: Console.WriteLine("Styczeń"); break;
                case 4: Console.WriteLine("Styczeń"); break;
                case 5: Console.WriteLine("Styczeń"); break;
                case 6: Console.WriteLine("Styczeń"); break;
                case 7: Console.WriteLine("Styczeń"); break;
                case 8: Console.WriteLine("Styczeń"); break;
                case 9: Console.WriteLine("Styczeń"); break;
                case 10: Console.WriteLine("Styczeń"); break;
                case 11: Console.WriteLine("Styczeń"); break;
                case 12: Console.WriteLine("Styczeń"); break;
                default: Console.WriteLine("Nie ma takiego miesiąca"); break;
            }
            Console.ReadKey(true);

                    }
    }
}
