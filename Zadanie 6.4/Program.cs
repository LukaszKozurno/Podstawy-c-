using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie_6._4
{
    class Program
    {
        static void Main(string[] args)
        {
            //6. Napisać program, który będzie umożliwiał użytkownikowi obliczenia pól figur płaskich.
            // Jeżeli użytkownik wybierze 1, to powinien mieć możliwość obliczenia pola prostokąta,
            //dla 2 – pola kwadratu, a dla 3 – pola trójkąta. Program powinien pytać użytkownika, które
            //pole chce obliczyć aż do momentu, kiedy użytkownik wpisze 0(zero).
            int wybor;
            double a, b;
            do
            {
                Console.WriteLine("Wybierz:");
                Console.WriteLine("1- oblicz pole prostokąta");
                Console.WriteLine("1- oblicz pole prostokąta");
                Console.WriteLine("2- oblicz pole kwadratu");
                Console.WriteLine("3- oblicz pole trójkąta");
                Console.WriteLine("0- koniec");
                Console.Write("Twoj wybór: ");
                wybor = Convert.ToInt32(Console.ReadLine());
                switch(wybor)
                {
                    case 0:
                        break;
                    case 1:
                        Console.Write("Podaj długość boku a = ");
                        a = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Podaj długość boku b = ");
                        b = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Pole prostokąta wynosi = {0}", a * b);
                        break;
                    case 2:
                        Console.Write("Podaj długość boku a = ");
                        a = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Pole kwadratu wynosi = {0}", a * a);
                        break;
                    case 3:
                        Console.Write("Podaj długość boku a = ");
                        a = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Podaj długość wysokości b = ");
                        b = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Pole trójkąta wynosi = {0}", a * b / 2);
                        break;
                    default:
                        Console.WriteLine.("Błąd w wyborze");
                        break;

                    }
                }
                while (wybor != 0) ;
        }
    }
}
