using System;

namespace pitagorasz
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a, b,c;
            Console.WriteLine("Add meg az a oldalt:");
            a=int.Parse(Console.ReadLine());
            Console.WriteLine("Add meg a b oldalt:");
            b =int.Parse(Console.ReadLine());
            Console.WriteLine("Add meg a c oldalt:");
            c =int.Parse(Console.ReadLine());
            if (a + b <= c)
            {
                Console.WriteLine("A háromszög nem létezik");
            }
            else if (b + c <= a)
            {
                Console.WriteLine("A háromszög nem létezik");
            }
            else if (a + c <= b)
            {
                Console.WriteLine("A háromszög nem létezik");
            }
            else
                Console.WriteLine("A háromszög létezik");
            Console.ReadKey();
        }
    }
}
