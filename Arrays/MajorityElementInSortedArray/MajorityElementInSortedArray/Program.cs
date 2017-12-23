using System;
using System.Collections.Generic;
using System.Linq;

namespace MajorityElementInSortedArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[] { 1, 1, 2, 4, 4, 4, 6, 6 };
            Majority(arr);
            Console.ReadKey();
        }

        public static void Majority(int[] arr)
        {
            int m = arr.Length / 2;
            Dictionary<int, int> map = new Dictionary<int, int>();
            for(int i=0;i<arr.Length;i++)
            {
                if(map.ContainsKey(arr[i]))
                {
                    map[arr[i]] = map[arr[i]] + 1;
                }
                else
                {
                    map.Add(arr[i], 1);
                }
            }
            int maxValue = map.Values.Max();
            int key = map.FirstOrDefault(x => x.Value == maxValue).Key;
            if(maxValue>m)
            {
                Console.WriteLine(key);
            }
            else
            {
                Console.WriteLine(-1);
            }
        }
    }
}
