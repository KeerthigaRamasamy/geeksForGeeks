using System;
using System.Collections.Generic;
using System.Linq;

namespace MajorityElement
{
    class Program
    {
        public static void Main(string[] args)
        {
            int[] arr = new int[8] { 3, 3, 4 ,2, 4, 4, 2, 4 };
            int majorityElement=MajorityElement(arr);
            if(majorityElement!=-1)
            {
                Console.WriteLine(majorityElement);
            }
            else
            {
                Console.WriteLine("NONE");
            }
            
            Console.ReadKey();
        }

        public static int MajorityElement(int[] arr)
        {
            int majorityElement = 0;
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
            int mid = arr.Length / 2;
            int maxOccurence = map.Values.Max();
            if(maxOccurence>mid)
            {
                majorityElement=map.FirstOrDefault(x => x.Value == maxOccurence).Key;
            }
            else
            {
                majorityElement= - 1;
            }
            return majorityElement;
        }
    }
}
