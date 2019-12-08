using System;

namespace Quicksort2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Palindrome kontrolü için kelime giriniz : ");
            string word = Console.ReadLine();

            for (int i = 0; i <= word.Length - 1; i++)
            {
                if (word[word.Length - i - 1] == word[i])
                {

                }
                else
                {
                    Console.WriteLine("Palindrome değildir.");
                    Console.ReadLine();
                }
            }
            Console.WriteLine("Palindromedur.");
            Console.ReadLine();
        }
    }
}
