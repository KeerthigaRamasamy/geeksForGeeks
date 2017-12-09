using System;
using System.Collections.Generic;
using System.Linq;

namespace OddOccurence
{
    class Program
    {
        static public void Main()
        {
            int t = Convert.ToInt32(Console.ReadLine());

            while ((t--) > 0)
            {
                int n = Convert.ToInt32(Console.ReadLine());
                int[] arr = new int[n];
                string[] inputs = Console.ReadLine().Split();
                for (int i = 0; i < n; i++)
                {
                    arr[i] = Convert.ToInt32(inputs[i]);
                }
                Console.WriteLine(OddOccurence(arr));
            }
        }
        public static int OddOccurence(int[] arr)
        {
            int oddOccurence = 0;
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
            foreach (int j in map.Values)
            {
                if (j % 2 != 0)
                {
                    oddOccurence = map.FirstOrDefault(s => s.Value == j).Key;
                    return oddOccurence;
                }
            }
            return oddOccurence;
        }
    }
}
