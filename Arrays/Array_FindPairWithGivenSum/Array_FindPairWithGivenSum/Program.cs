using System;
using System.Collections.Generic;

namespace Array_FindPairWithGivenSum
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int[] arr = new int[6] {1, 4, 45, 6, 10, -8 };
            int sum = 16;
            FindPair(arr, sum);
            Console.ReadKey();

        }
        public static void FindPair(int[] arr,int sum)
        {
            Dictionary<int, int> map = new Dictionary<int, int>();
            for(int i=0;i<arr.Length;i++)
            {
               if(!map.ContainsKey(arr[i]))
                {
                    map.Add(arr[i], 1);
                }
                int diff = Math.Abs((sum - arr[i]));
                if(map.ContainsKey(diff))
                {
                    Console.WriteLine("The pair is " + diff + " " + arr[i]);
                    return;
                }
            }
            Console.WriteLine("The array doesn't have numbers that gives the sum");
        }
    }
}
