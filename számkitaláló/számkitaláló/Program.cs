using System;

namespace számkitaláló
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int tipp, r, tippszám;
            Console.WriteLine("Gondoltam egy számra");
            r= random.Next(0,100);    
            tipp=int.Parse(Console.ReadLine());
            tippszám = 0;
            while (tipp != r)
            {
                if (tipp > r)
                {
                    Console.WriteLine("Kissebb");
                    tipp = int.Parse(Console.ReadLine());
                    tippszám++;
                }
                if (tipp < r)
                {
                    Console.WriteLine("Nagyobb");
                    tipp = int.Parse(Console.ReadLine());
                    tippszám++;
                }
                if (tipp == r)
                {
                    Console.WriteLine("Eltaláltad");
                    Console.WriteLine(tippszám);
                }
            }
            Console.ReadKey();
        }

    }
}
