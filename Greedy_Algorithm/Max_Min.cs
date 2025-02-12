//Max Min
/*
Input:
N = 5
A[] = {-2, 1, -4, 5, 3}
Output: 1
Explanation: min = -4, max =  5. Sum = -4 + 5 = 1
*/





/*****************************
Solution in C#
*****************************/

using System;
using System.Linq;
namespace Demo
{
	class Program
	{
		public static int findSum(int[] arr)
		{
			int min = arr.Min();
			int max = arr.Max();
			return (min+max);
		}
		
		public static void Main(string[] args)
		{
			int[] arr = new int[] {-2, 1, -4, 5, 3};
			Console.WriteLine(findSum(arr));
		}
	}
}











/*****************************
Solution in C++
*****************************/


int findSum(int A[], int n)
{
	int minimum = INT_MAX;
	int maximum = INT_MIN;
	for(int i = 0; i<N; i++)
    {
        minimum = min(minimum,A[i]);
        maximum = max(maximum,A[i]);
    }
    return (maximum + minimum);
}