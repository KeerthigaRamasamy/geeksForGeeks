using System;

namespace SumDigitsOfNumber
{
    class Program
    {
        public static int sum=0;
        static void Main(string[] args)
        {
            int n = 12;
            sum = SumRecursive(n);
            Console.WriteLine(sum);
            Console.ReadKey();
        }

        public static int SumRecursive(int n)
        {
            if(n!=0)
            {
                sum = sum + n % 10;
                SumRecursive(n / 10);
            }
            return sum;
        }

        public static int SumIterative(int n)
        {
            sum = 0;
            while(n/10!=0)
            {
                sum = sum + (n % 10);
                n = n / 10;
            }
            return sum;
        }
    }
}
