using System;
using System.Collections.Generic;
using System.Linq;

namespace Quicksort15
{
    class Program
    {
        static void Main(string[] args)
        {
            string test = "adfsfafsdfasdf";
            List<char> f = test.ToList();
            List<IGrouping<char, char>> grouped = f.GroupBy(a => a).OrderBy(a => a.Key).ToList();

            foreach (IGrouping<char, char> item in grouped)
            {
                Console.WriteLine(item.Key + " : " + item.Count());
            }
            Console.ReadLine();
        }
    }
}
