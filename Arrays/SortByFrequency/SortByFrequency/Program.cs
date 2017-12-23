using System;
using System.Collections.Generic;
using System.Linq;

namespace SortByFrequency
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[] { 2, 5, 2, 6, -1, 9999999, 5, 8, 8, 8 };
            Sort(arr);
            Console.ReadKey();
        }
        public static void Sort(int[] arr)
        {
            Dictionary<int, int> map = new Dictionary<int, int>();
            for (int i = 0; i < arr.Length; i++)
            {
                if (map.ContainsKey(arr[i]))
                {
                    map[arr[i]] = map[arr[i]] + 1;
                }
                else
                {
                    map.Add(arr[i], 1);
                }
            }
            while (map.Count != 0)
            {
                int max = map.Values.Max();
                int key = map.FirstOrDefault(k => k.Value == max).Key;
                while (key!=default(int) && map.ContainsKey(key))
                {
                    key = map.FirstOrDefault(k => k.Value == max).Key;
                    while ((max--) > 0)
                    {
                        Console.Write(key + " ");
                    }
                    map.Remove(key);
                    key = map.FirstOrDefault(k => k.Value == max).Key;
                }
            }
        }
    }
}
