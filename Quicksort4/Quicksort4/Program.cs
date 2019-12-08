using System;

namespace Quicksort4
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] can = { 1000, 900, 5 };
            int toplam = 0;
            for (int i = 0; i <= can.Length-1; i++)
            {
                toplam += can[i];
            }
            Console.WriteLine(toplam);
            Console.ReadLine();
        }
    }
}
