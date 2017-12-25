using System;

namespace PermutationsOfAString
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = "abcd";
            Permute(s.ToCharArray(), 0, s.Length - 1);
            Console.ReadKey();
        }

        public static void Permute(char[] a,int l,int r)
        {
            if(l==r)
            {
                string s = new string(a);
                Console.WriteLine(s);
            }
            for(int i=l;i<=r;i++)
            {
                Swap(a, l, i);
                Permute(a, l + 1, r);
                Swap(a, l, i);
            }
        }

        public static void Swap(char[] a,int x,int y)
        {
            char temp = a[x];
            a[x] = a[y];
            a[y] = temp;
        }
    }
}
