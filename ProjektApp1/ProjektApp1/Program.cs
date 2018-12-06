using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjektApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj liczbę osób do wprowadzenia");
            int yy = int.Parse(Console.ReadLine());
            Osoba[] tablicaOsob = new Osoba[yy];

            for(int y = 0; y < tablicaOsob.Length; y++)
            {
                tablicaOsob[y] = new Osoba();
                tablicaOsob[y].PobierzDane();
                Console.Clear();
            }

            while (true)
            {
                for (int y = 0; y < tablicaOsob.Length; y++)
                {
                    Console.WriteLine($"{y + 1}. {tablicaOsob[y].PrzedstawSie()}");
                }

                Console.WriteLine("Podaj indeks osoby, co do której chcesz pozyskać adres");
                int.TryParse(Console.ReadLine(), out int xx);
                Console.WriteLine("Wciśnij enter by kontynuować");
                Console.ReadLine();
                Console.Clear();

                    try
                    {
                        Console.WriteLine($"{tablicaOsob[xx - 1].PrzedstawSie()} " +
                            $"\n{tablicaOsob[xx - 1].PobierzAdres()}");
                    }
                    catch (Exception e)
                    {
                        Console.Clear();
                        Console.WriteLine("Wartość poza zakresem");
                        continue;
                    }
                    Console.WriteLine("Wciśnij enter by kontynuować");
                    Console.ReadLine();
                    Console.Clear();
                    continue;
            }
        }
    }
}
