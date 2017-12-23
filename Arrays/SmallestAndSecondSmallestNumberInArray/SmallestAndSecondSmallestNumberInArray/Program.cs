using System;

namespace SmallestAndSecondSmallestNumberInArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[] {2,8,1,5,6,3};
            Smallest(arr);
            Console.ReadKey();
        }

        public static void Smallest(int[] arr)
        {
            int s = Int32.MaxValue, s1 = Int32.MaxValue;
            for(int i=0;i<arr.Length;i++)
            {
                if(arr[i]<s)
                {
                    s1 = s;
                    s = arr[i];
                }
                else if(arr[i]<s1 && arr[i]!=s)
                {
                    s1 = arr[i];
                }
            }
            if(s!=s1 || s!= Int32.MaxValue || s1!= Int32.MaxValue)
            {
                Console.WriteLine(s + " " + s1);
            }
            else
            {
                Console.WriteLine(-1);
            }
        }
    }
}
