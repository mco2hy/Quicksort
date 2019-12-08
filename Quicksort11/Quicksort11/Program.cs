using System;

namespace Quicksort11
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Write("Sayı Girin : ");
                int sayi = Convert.ToInt32(Console.ReadLine());

                if (sayi % 2 == 0)
                {
                    Console.WriteLine("Çift");
                }
                else
                {
                    Console.WriteLine("Tek");
                }
            }
        }
    }
}

