using System;
using System.Collections.Generic;

namespace Array_FindPairWithGivenSum
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int[] arr = new int[74] { 142, 712, 254, 869, 548, 645, 663, 758, 38, 860, 724, 742, 530, 779, 317, 36, 191, 843, 289, 107, 41, 943, 265, 649, 447, 806, 891, 730, 371, 351, 7, 102, 394, 549, 630, 624, 85, 955, 757, 841, 967, 377, 932, 309, 945, 440, 627, 324, 538, 539, 119, 83, 930, 542, 834, 116, 640, 659, 705, 931, 978, 307, 674, 387, 22, 746, 925, 73, 271, 830, 778, 574, 98, 513, };
            int sum = 165;
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
               if(arr[i]<=sum)
                {
                    int diff = Math.Abs((sum - arr[i]));
                    if (map.ContainsKey(diff))
                    {
                        Console.WriteLine("Yes");
                        return;
                    }
                }
               
            }
            Console.WriteLine("No");
        }
    }
}
