//Median of an array
/*
Input: arr[] = [90, 100, 78, 89, 67]
Output: 89
Explanation: After sorting the array middle element is the median. 
*/


using System;
namespace Demo
{
    class Program
    {
        public static double findMedian(int[] arr)
        {
            Array.Sort(arr);
            int n = arr.Length;
            int mid = n/2;
            if(n%2==0)
            {
                return (arr[mid] + arr[mid-1])/2.0;
            }
            else
            {
                return arr[mid];
            }
        }
        
        public static void Main(string[] args)
        {
            int[] arr = new int[] {56, 67, 30, 79};
            double res = findMedian(arr);
            Console.WriteLine(res);
        }
    }
}