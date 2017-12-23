using System;
using System.Collections.Generic;
using System.Linq;

namespace LeadersInArray
{
    class Program
    {
        static public void Main()
        {
            int t = Convert.ToInt32(Console.ReadLine());
            while ((t--) > 0)
            {
                int n = Convert.ToInt32(Console.ReadLine());
                string[] input = Console.ReadLine().Split();
                int[] arr = new int[n];
                for (int i = 0; i < n; i++)
                {
                    arr[i] = Convert.ToInt32(input[i]);
                }
                Leaders(arr);
                Console.WriteLine();
            }
            Console.ReadKey();
        }
        public static void Leaders(int[] arr)
        {
            Dictionary<int, int> map = new Dictionary<int, int>();
           
            int n = arr.Length;
            int max = arr[n-1];
            Console.Write(max + " ");
            for (int i = n - 2; i >= 0; i--)
            {
                if (arr[i] > max)
                {
                    Console.Write(arr[i] + " ");
                    max = arr[i];
                }
            }
        }
    }
}
