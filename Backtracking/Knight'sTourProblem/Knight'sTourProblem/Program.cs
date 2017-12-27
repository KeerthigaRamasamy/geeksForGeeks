using System;

namespace Knight_sTourProblem
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] sol = new int[8, 8] { {-1,-1,-1, -1, -1, -1, -1, -1 }, { -1, -1, -1, -1, -1, -1, -1, -1 }, { -1, -1, -1, -1, -1, -1, -1, -1 }, { -1, -1, -1, -1, -1, -1, -1, -1 }, { -1, -1, -1, -1, -1, -1, -1, -1 }, { -1, -1, -1, -1, -1, -1, -1, -1 }, { -1, -1, -1, -1, -1, -1, -1, -1 }, { -1, -1, -1, -1, -1, -1, -1, -1 } };
            int[] xMove = new int[] {2,1,-1,-2,-2,-1,1,2 };
            int[] yMove = new int[] {1,2,2,1,-1,-2,-2,-1 };
            sol[0, 0] = 0;
            if(KnightTour(sol,0,0,1,8,xMove,yMove))
            {
                for(int i=0;i<8;i++)
                {
                    for(int j=0;j<8;j++)
                    {
                        Console.Write(sol[i, j] + " ");
                    }
                    Console.WriteLine();
                }
            }
            Console.ReadKey();
        }

        public static bool isSafe(int[,] sol,int x,int y,int n)
        {
            return (x >= 0 && x<n && y>=0 && y < n && sol[x, y] == -1);
        }

        public static bool KnightTour(int[,] sol,int x,int y,int movei,int n,int[] xMove,int[] yMove)
        {
            int nextMoveX, nextMoveY;
            if (movei==n*n)
            {
                return true;
            }
            for(int i=0;i<8;i++)
            {
                nextMoveX = x + xMove[i];
                nextMoveY = y + yMove[i];
                if (isSafe(sol, nextMoveX, nextMoveY, n))
                {
                    sol[nextMoveX, nextMoveY] = movei;                    
                    if (KnightTour(sol, nextMoveX, nextMoveY, movei + 1, n, xMove, yMove))
                    {
                        return true;
                    }
                    sol[nextMoveX, nextMoveY] = -1;
                }
            }
            return false;
        }
    }
}
