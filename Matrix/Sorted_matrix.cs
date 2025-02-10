//Sorted Matrix

/*
Input:
N=3
Mat=[[1,5,3],[2,8,7],[4,6,9]]
Output:
1 2 3 
4 5 6
7 8 9
Explanation:
Sorting the matrix gives this result.
*/





/***********************
Solution in C#
***********************/


//Brute-Force Approach
//T.C = 
//S.C = O(N*N)
using System;
namespace demo
{
    class program
    {
        public static int[,] sortedMatrix(int n, int[,] arr)
        {
            int row = arr.GetLength(0);
            int col = arr.GetLength(1);
            
            //Temp array
            int[] temp = new int[row*col];
            
            int index=0;
            for(int i=0; i<row; i++)
            {
                for(int j=0; j<col; j++)
                {
                    temp[index] = arr[i,j];
                    index++;
                }
            }
            
            //Sorting
            Array.Sort(temp);
            
            int x = 0;
            for(int i=0; i<row; i++)
            {
                for(int j=0; j<col; j++)
                {
                    arr[i,j] = temp[x];
                    x++;
                }
            }
            return arr;
        }
        
        public static void Main(string[] args)
        {
            int n=3;
            int[,] arr = new int[,] {{1,5,3}, {2,8,7}, {4,6,9}};
            sortedMatrix(n, arr);
            
            //print
            for(int i=0; i<n; i++)
            {
                for(int j=0; j<n; j++)
                {
                    Console.Write(arr[i,j]);
                }
                Console.WriteLine();
            }
        }
    }
}












