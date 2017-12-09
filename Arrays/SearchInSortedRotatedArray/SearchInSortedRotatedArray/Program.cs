using System;

namespace SearchInSortedRotatedArray
{
    class Program
    {
        static public void Main()
        {
            int t = Convert.ToInt32(Console.ReadLine());

            while ((t--) > 0)
            {
                string[] inputs1 = Console.ReadLine().Split();
                int n = Convert.ToInt32(inputs1[0]);
                int key = Convert.ToInt32(inputs1[1]);
                int[] arr = new int[n];
                string[] inputs = Console.ReadLine().Split();
                for (int i = 0; i < n; i++)
                {
                    arr[i] = Convert.ToInt32(inputs[i]);
                }
                int index = Search(arr, key);
                if (index == -1)
                {
                    Console.WriteLine("OOPS! NOT FOUND");
                }
                else
                {
                    Console.WriteLine(index);
                }
            }
        }
        public static int Search(int[] arr, int key)
        {
            int index = -1;
            int n = arr.Length;
            int s1 = 0, s2 = 0, e1 = 0, e2 = n - 1;
            for (int i = 0; i < n - 1; i++)
            {
                if (!(arr[i] < arr[i + 1]))
                {
                    e1 = i;
                    s2 = i + 1;
                    break;
                }
                else
                {
                    s2 = s1;
                    e1 = e2;
                   
                }
            }
            if (key >= arr[s1] && key <= arr[e1])
            {
                index = BinarySearch(arr, s1, e1, key);
                if (index != -1)
                {
                    return index;
                }
            }
            if (key <= arr[s2] && key >= arr[e2])
            {
                index = LinearSearch(arr, s2, e2, key);
                if (index != -1)
                {
                    return index;
                }
            }
            return index;
        }
        public static int LinearSearch(int[] arr, int s, int e, int key)
        {
            int index = -1;
            for (int i = s; i <= e; i++)
            {
                if (arr[i] == key)
                {
                    return i;
                }
            }
            return index;
        }
        public static int BinarySearch(int[] arr, int s, int e, int key)
        {

            if ((e >= s))
            {
                int m = s + (e - s) / 2;
                if (arr[m] == key)
                {
                    return m;
                }

                if (key < arr[m])
                {
                    //left
                    return BinarySearch(arr, s, m - 1, key);
                }
                else
                {
                    return BinarySearch(arr, m + 1, e, key);
                }
            }

            return -1;
        }
    }
}
