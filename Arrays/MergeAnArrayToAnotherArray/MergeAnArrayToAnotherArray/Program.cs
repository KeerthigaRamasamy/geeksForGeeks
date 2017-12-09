using System;

namespace MergeAnArrayToAnotherArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int m = Convert.ToInt32(Console.ReadLine());
            int n = Convert.ToInt32(Console.ReadLine());
            int[] arr1 = new int[m];
            int[] arr2 = new int[n];
            int[] result = new int[m+n];
            string[] input1 = Console.ReadLine().Split();
            for(int i=0;i<arr1.Length;i++)
            {
                arr1[i] = Convert.ToInt32(input1[i]);
            }
            string[] input2 = Console.ReadLine().Split();
            for (int i = 0; i < arr2.Length; i++)
            {
                arr2[i] = Convert.ToInt32(input2[i]);
            }
            result = Merge(arr1, arr2);
            for (int i=0;i<result.Length;i++)
            {
                Console.Write(result[i] + " ");
            }
            Console.ReadKey();
        }
        public static int[] Merge(int[] arr1,int[] arr2)
        {
            int m = arr1.Length;
            int n = arr2.Length;
            int[] result= new int[m+n];

            int i = 0, j = 0,k=0;
            while(i<m && j<n && k<(m+n))
            {
                if(arr1[i]<arr2[j])
                {
                    result[k] = arr1[i];
                    i++;
                }
                else
                {
                    result[k] = arr2[j];
                    j++;
                }
                k++;
            }
            while((i<m) && (k<(m+n)))
            {
                result[k] = arr1[i];
                i++;
                k++;
            }
            while((j< n) && (k < (m + n)))
            {
                result[k] = arr2[j];
                j++;
                k++;
            }
            return result;
        }
    }
}
