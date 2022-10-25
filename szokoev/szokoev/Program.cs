using System;

namespace szokoev
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int szokoev;
            Console.WriteLine("Adj meg egy évszámot");
            szokoev = int.Parse(Console.ReadLine());
            Console.WriteLine(szokoev);
            if (szokoev % 4 == 0 & szokoev % 100 == 0) 
            {
                Console.WriteLine("Szőkőév");
            }
            else
            { 
            Console.WriteLine("Nem szökőév");
                    }


            Console.ReadKey();

        }
    }
}
