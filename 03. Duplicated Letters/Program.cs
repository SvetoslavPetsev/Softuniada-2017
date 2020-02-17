using System;
using System.Linq;
using System.Collections.Generic;

namespace _3._Duplicated_Letters
{
    class Program
    {
        static bool HaveDuplicates(List<char> arr)
        {
            bool have = false;

            for (int i = 0; i < arr.Count - 1; i++)
            {
                char currSimbol = arr[i];
                char nextSymbol = arr[i + 1];
                if (currSimbol == nextSymbol)
                {
                    have = true;
                    break;
                }
            }
            return have;
        }

        static void RemoveDuplicates(List<char> arr)
        {
            for (int i = 0; i < arr.Count - 1; i++)
            {
                char currSimbol = arr[i];
                char nextSymbol = arr[i + 1];
                if (currSimbol == nextSymbol)
                {
                    arr.RemoveRange(i, 2);
                    break;
                }
            }
        }
        static void Main()
        {
            string input = Console.ReadLine();
            List<char> elements = new List<char>();

            for (int i = 0; i < input.Length; i++)
            {
                char curr = input[i];
                elements.Add(curr);
            }
            int counterOpperation = 0;
            while (HaveDuplicates(elements))
            {
                RemoveDuplicates(elements);
                counterOpperation++;
            }

            if (elements.Count == 0)
            {
                Console.WriteLine("Empty String");
            }

            else
            {
                Console.WriteLine(string.Join("", elements));
            }
            Console.WriteLine($"{counterOpperation} operations");
        }
    }
}
