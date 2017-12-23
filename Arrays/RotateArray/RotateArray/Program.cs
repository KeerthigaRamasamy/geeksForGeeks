using System;

namespace RotateArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[] { 1, 2, 3, 4, 5,6,7 };
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }
            RotateArrayClockWise(arr, 2);
            Console.WriteLine();
            Console.WriteLine("clockwise rotation");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }
            Console.WriteLine();

            Console.ReadKey();
        }
        public static void Reverse(int[] arr,int i,int j)
        {
            //int i = 0, j = arr.Length - 1;
            while (i < j)
            {
                //swap
                int temp = arr[i];
                arr[i] = arr[j];
                arr[j] = temp;
                i++;
                j--;
            }
        }
        public static void RotateArrayClockWise(int[] arr,int k)
        {
            if(k>arr.Length)
            {
                return;
            }
           
            Reverse(arr,0,k-1);
            Reverse(arr,k,arr.Length-1);
            Reverse(arr, 0, arr.Length - 1);
        }
    }
}
