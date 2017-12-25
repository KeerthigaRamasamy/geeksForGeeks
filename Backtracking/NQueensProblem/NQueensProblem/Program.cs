using System;

namespace NQueensProblem
{
    class Program
    {
        static void Main(string[] args)
        {
            const int n = 4;
            int[,] arr = new int[n, n] { {0,0,0,0 }, { 0, 0, 0, 0 }, { 0, 0, 0, 0 }, { 0, 0, 0, 0 } };
            if(PossibleArrangements(arr,0,n))
            {
                for(int i=0;i<n;i++)
                {
                    for(int j=0;j<n;j++)
                    {
                        Console.Write(arr[i, j] + " ");
                    }
                    Console.WriteLine();
                }
            }
            else
            {
                Console.WriteLine("Cannot arrange queens");
            }
            Console.ReadKey();
        }
        public static bool PossibleArrangements(int[,] arr,int col,int n)
        {
           if(col>=n)
            {
                return true;
            }
           for(int i=0;i<n;i++)
            {
                if(IsSafe(arr,i,col,n))
                {
                    arr[i, col] = 1;
                    if(PossibleArrangements(arr, col + 1, n))
                    {
                        return true;
                    }
                    arr[i,col]=0;
                }
            }
            return false;
        }
        public static bool IsSafe(int[,] arr,int row,int col,int n)
        {
            int i = 0, j = 0;
            //row on left
            for(i=0; i<col; i++)
            {
                if(arr[row,i]==1)
                {
                    return false;
                }
            }

            //upper diagonal on left
            i = row;
            j = col;
            while(i>=0 && j>=0)
            {
                if(arr[i,j]==1)
                {
                    return false;
                }
                i--;
                j--;
            }

            //lower diagonal on left
            i = row;
            j = col;
            while (i < n && j >= 0)
            {
                if (arr[i, j] == 1)
                {
                    return false;
                }
                i++;
                j--;
            }
            return true;
        }
    }
}

