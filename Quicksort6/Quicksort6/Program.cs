using System;

namespace Quicksort6
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] can = { 10, 900, 25 };
            int enKucuk = can[0];

            for (int i = 0; i <= can.Length - 1; i++)
            {
                if (can[i] < enKucuk)
                {
                    enKucuk = can[i];
                }
            }
            Console.WriteLine(enKucuk);
            Console.ReadLine();
        }
    }
    }

