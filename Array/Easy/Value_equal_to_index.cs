//Value equal to index (1-based indexing)
/*
Input: arr[] = [15, 2, 45, 4 , 7]
Output: [2, 4]
*/


using System;
using System.Collections.Generic;
namespace Demo
{
    class Program
    {
        public int[] valueEqualToIndex(int[] arr)
        {
            List<int> li = new List<int>();
            for(int i=0; i<arr.Length; i++)
            {
                if(arr[i]==(i+1))
                {
                    li.Add(arr[i]);
                }
            }
            return li.ToArray();
        }
        
        public static void Main(string[] args)
        {
            int n = 5;
            int[] arr = new int[] {15, 2, 45, 4 , 7};
            
            Program p = new Program();
            int[] res = p.valueEqualToIndex(arr);
            
            for(int i=0; i<res.Length; i++) {
                Console.Write(res[i] + " ");
            }
        }
    }
}