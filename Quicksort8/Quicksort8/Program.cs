using System;

namespace Quicksort8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bir sayı girin : ");
            int sayi = Convert.ToInt32(Console.ReadLine());
            string[] isim = { "Mehmet Can Onur YARALI" };
            for (int i = 0; i < sayi; i++)
            {
                Console.WriteLine(isim[0]);
            }
            Console.ReadLine();
        }
    }
}
