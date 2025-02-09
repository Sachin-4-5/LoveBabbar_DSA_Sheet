//Count of perfect squares.
/*
Input: n = 9
Output: 2
Explanation: 1 and 4 are the only Perfect Squares less than 9. So, the Output is 2.
*/



/********************
Solution in C#
********************/


//Naive approach
using System;
namespace Demo
{
	class Program
	{
		public static int countSquares(int n)
		{
			int count=0;
			for(long i=1; i<=n/2; i++)
			{
				if(i*i < n)
					count++;
			}
			return count;
		}
		
		public static void Main(string[] args)
		{
			int n = 9;
			int res = countSquares(n);
			Console.WriteLine(res);
		}
	}
}






//Optimized soln
using System;
namespace Demo
{
	class Program
	{
		public static int countSquares(int n)
		{
			return (int) Math.Sqrt(n);
		}
		
		public static void Main(string[] args)
		{
			int n = 9;
			int res = countSquares(n);
			Console.WriteLine(res);
		}
	}
}