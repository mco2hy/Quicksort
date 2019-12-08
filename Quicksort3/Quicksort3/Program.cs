using System;

namespace Quicksort3
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Sayı girin");
                int sayi = Convert.ToInt32(Console.ReadLine());

                for (int i = 0; i <= sayi; i++)
                {
                    Console.WriteLine(i);
                }
            }
            Console.ReadLine();
        }
    }
    
}
