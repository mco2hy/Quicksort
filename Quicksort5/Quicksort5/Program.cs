using System;

namespace Quicksort5
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] can = { 1000, 900, 5000 };
            int enBuyuk = 0;
            
            for (int i = 0; i <= can.Length - 1; i++)
            {
                if (can[i] > enBuyuk )
                {
                    enBuyuk = can[i];
                }
            }
            Console.WriteLine(enBuyuk);
            Console.ReadLine();
        }
    }
}
