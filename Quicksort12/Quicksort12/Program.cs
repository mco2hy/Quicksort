using System;

namespace Quicksort12
{
    class Program
    {
        static void Main(string[] args)
        {
            int sayac1 = 0;
            int sayac2 = 0;
            for (int i = 1; i < 1001; i++)
            {
                if (i % 2 == 0)
                {
                    sayac1++;
                }
                else
                {
                    sayac2++;
                }
            }
            Console.WriteLine(sayac1 + " Çift");
            Console.WriteLine(sayac2 + " Tek");
            Console.ReadLine();
        }
    }
}
