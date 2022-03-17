using System;
using System.Linq;
using System.Collections.Generic;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            var result = StalinSort(new int[] { 1, 3, 2, 4, 5 });

            foreach (var item in result)
            {
                Console.Write($"{item} ");
            }
        }

        public static int[] StalinSort(int[] arr)
        {
            var survivors = new List<int>();
            var len = arr.Length;
            survivors.Add(arr[len - 1]);

            for (int i = len - 1; i > 0; i--)
            {
                if (arr[i] > arr[i - 1])
                {
                    survivors.Add(arr[i - 1]);
                }
                else
                {
                    break;
                }
            }

            return survivors.Reverse<int>().ToArray();
        }
    }
}
