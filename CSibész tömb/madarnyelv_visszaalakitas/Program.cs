using System;

namespace madarnyelv_visszaalakitas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int hatos = 0;
            bool voltmar = false;
            byte[] dobások = new byte[100];
            Random random = new Random();
            for (int i = 0; i < 100; i++)
            {
                dobások[i] = (byte)random.Next(0, 6);
                if (dobások[i] == 6)
                {
                    hatos++;
                }
                if (dobások[i] == 6 && voltmar == false)
                {
                    Console.WriteLine("első hatos{i+1}");
                    voltmar = true;
                }
            }
            Console.WriteLine(dobások);
            Console.ReadKey();
        }
    }
}
