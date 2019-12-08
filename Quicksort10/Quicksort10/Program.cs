using System;

namespace Quicksort10
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {


                Console.WriteLine("Sayı Girin : ");
                try
                {
                    int sayi = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("İnteger");
                }
                catch (Exception e)
                {

                    Console.WriteLine("İnteger değil");
                }
            }




            Console.ReadLine();
        }
    }
}
