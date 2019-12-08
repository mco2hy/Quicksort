using System;
using System.Collections.Generic;
using System.Linq;

namespace Quicksort7
{
    class Program
    {
        static void Main(string[] args)
        {

            double enKucuk = Double.MaxValue;
            int yeri = 0;
            List<double> fark = new List<double>();
             
             double [] sayi = { 5, 4, 6, 10, 12, 16, 18, 20, 25, 26 };


            double ortalama = sayi.Average();

            for (int i = 0; i <= sayi.Length - 1; i++)
            {
                fark.Add(Math.Abs(ortalama - sayi[i]));
            }
            for (int i = 0; i <= sayi.Length - 1; i++)
            {
                if (fark[i] < enKucuk)
                {
                    enKucuk = fark[i];
                    yeri = i;
                }

            }
            Console.WriteLine(fark[5]);
            fark.ForEach(Console.WriteLine);
            Console.WriteLine(ortalama);
            Console.WriteLine(sayi[yeri]);


            Console.ReadLine();
        }
    }
}
