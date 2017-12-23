using System;

namespace ReverseArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[] {1,2,3,4,5 };
            for(int i=0;i<arr.Length;i++)
            {
                Console.Write(arr[i] + " ");
            }
            Reverse(arr);
            Console.WriteLine();
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }
            Console.ReadKey();

        }
        public static void Reverse(int[] arr)
        {
            int i = 0, j = arr.Length - 1;
            while(i<j)
            {
                //swap
                int temp = arr[i];
                arr[i] = arr[j];
                arr[j] = temp;
                i++;
                j--;
            }
        }
    }
}
