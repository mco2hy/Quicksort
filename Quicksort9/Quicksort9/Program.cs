using System;

namespace Quicksort9
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] sayi = { -5, -4, 6, 10, -12, 0, 18, -20, 25, -26 };

            for (int i = 0; i < sayi.Length - 1; i++)
            {
                if (sayi[i] < 0)
                {
                    Console.WriteLine(sayi[i] + " Negatif");
                }
                else
                {
                    Console.WriteLine(sayi[i] + " Pozitif");
                }
            }

            Console.ReadLine();
        }
    }
}
