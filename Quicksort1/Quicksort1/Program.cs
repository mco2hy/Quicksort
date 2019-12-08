using System;

namespace Quicksort1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Tersten Yazılacak Metni Giriniz = ");
            string word = Console.ReadLine();
            for (int i = 0; i <= word.Length - 1; i++)
            {
                Console.Write(word[word.Length-i-1]);
            }
            Console.ReadLine();
        }
    }
}
