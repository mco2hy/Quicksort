using System;

namespace Quicksort14
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bir kelime giriniz : ");
            string kelime = Console.ReadLine();
            int sayac = 0;

            for (int i = 0; i <= kelime.Length-1; i++)
            {
                Console.WriteLine(kelime[i]);
                sayac++;
            }
            Console.WriteLine(sayac);
            Console.ReadLine();
        }
    }
}
