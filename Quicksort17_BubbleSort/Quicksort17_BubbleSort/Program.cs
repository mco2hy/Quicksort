using System;

namespace Quicksort17_BubbleSort
{
    class Program
    {
        static void Main(string[] args)
        {
            int swap;
            int [] array = new int [] {24, 6, 19, 94, 1, 9, 0, 5};
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + " ");
            }
            Console.WriteLine();

            for (int i = 0; i < array.Length; i++)
            {
                for (int j = i; j < array.Length; j++)
                {
                    if (array[i] > array[j])
                    {
                        swap = array[i];
                        array[i] = array[j];
                        array[j] = swap;
                    }
                }
            }

            Console.WriteLine();

            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + " ");
            }
            
            Console.ReadLine();
        }
    }
}
