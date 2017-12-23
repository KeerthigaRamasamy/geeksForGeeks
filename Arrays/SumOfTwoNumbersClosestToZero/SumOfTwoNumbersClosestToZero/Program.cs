using System;

namespace SumOfTwoNumbersClosestToZero
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[] { -8 ,- 66, - 60 };
            SumOfTwo(arr);
            Console.ReadKey();
        }

        public static void SumOfTwo(int[] arr)
        {
            Array.Sort(arr);
            int num1 = 0, num2 = 0,sum=Int32.MaxValue;
            int l = 0, r = arr.Length - 1;
            while(l<r)
            {
                int temp = arr[l] + arr[r];
                if (Math.Abs( temp) <Math.Abs( sum))
                {
                    sum = temp;
                    num1 = arr[l];
                    num2 = arr[r];
                }
                if (temp<0)
                {
                    l++;
                }
                else
                {
                    r--;
                }
                
            }
            Console.WriteLine("the numbers " + num1 + " and " + num2 + " gives sum " + sum);
        }
    }
}
