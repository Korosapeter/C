using System;

namespace ko_papir_ollo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //random szám generátor előkészítés
            Random vszg = new Random();
            int választás, random;
            Console.WriteLine("Adja meg a választásást");
            Console.Write("kő(1),papír(2),olló(3) (Számot adj meg)");
            választás = int .Parse(Console.ReadLine());
            random = vszg.Next(1, 4);
            if (választás > random)
                Console.WriteLine("Nyertél");
            else if (választás == random)
                Console.WriteLine("Döntetlen");
            else Console.WriteLine("Vesztettél");
            Console.ReadKey()


        }
    }
}
