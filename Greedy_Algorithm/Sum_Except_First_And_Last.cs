//Sum Except First amd Last
/*
Input: arr[] = [5, 24, 39, 60, 15, 28, 27, 40, 50, 90]
Output: 283
*/


using System;
namespace Demo
{
	class Program
	{
		public static int sumExceptFirstLast(int[] arr)
		{
			int sum=0;
			for(int i=1; i<arr.Length-1; i++) 
			{
				sum += arr[i];
			}
		}
		
		public static void Main(string[] args)
		{
			int[] arr = new int[] {5, 24, 39, 60, 15, 28, 27, 40, 50, 90};
			Console.WriteLine(sumExceptFirstLast(arr));
		}
	}
}
