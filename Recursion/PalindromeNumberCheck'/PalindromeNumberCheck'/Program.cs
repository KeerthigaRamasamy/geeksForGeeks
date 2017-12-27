using System;
using System.Collections;
using System.Collections.Generic;

namespace PalindromeNumberCheck_
{
    class Program
    {
        public static bool isPalindrome = false;
        public static Stack<int> stack=new Stack<int>();
        public static int n = 123211;
        public static int n1 = n;
        static void Main(string[] args)
        {
            Console.WriteLine(IsPalindrome(n));
            Console.ReadKey();
        }

        public static bool IsPalindrome(int n)
        {
            if(n!=0)
            {
                n = n / 10;
                IsPalindrome(n);
            }
            if(n % 10 == n1 % 10)
            {
                n1 = n1 / 10;
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
