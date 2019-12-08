using System;

namespace Quicksort13
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] sayilar = { 5, 10, 35, 43, 51, 52, 68, 27, 99, 100 };
            int[] ciftler = new int[sayilar.Length];
            int[] tekler = new int[sayilar.Length];

            for (int i = 0; i <= sayilar.Length-1; i++)
            {
                if (sayilar[i] % 2 == 0)
                {
                    ciftler[i] = sayilar[i];
                }
                else
                {
                    tekler[i] = sayilar[i];
                }
            }

            Console.WriteLine("Çiftler");
            for (int i = 0; i <= ciftler.Length-1; i++)
            {
                if (ciftler[i] != 0)
                {
                    Console.Write(ciftler[i]+ ", ");
                }
                
            }

            Console.WriteLine("");
            Console.WriteLine("*-*-*-*-*-*-*-*-*-*");
            Console.WriteLine("Tekler");
            for (int i = 0; i <= tekler.Length-1; i++)
            {
                if (tekler[i] != 0)
                {
                    Console.Write(tekler[i] + ", ");
                }
                
            }




            Console.ReadLine();
        }
    }
}
