//Rotate Array by 1
/*
Input: arr[] = [1, 2, 3, 4, 5]
Output: [5, 1, 2, 3, 4]
*/




/***********************************
Solution in C#
***********************************/

using System;
namespace Demo
{
    class Program
    {
        public void rotate(int[] arr)
        {
            int startIndex = 1;
            int endIndex = arr.Length-1;
            Array.Reverse(arr);
            Array.Reverse(arr, startIndex, endIndex);
        }
        
        public static void Main(string[] args)
        {
            int n = 5;
            int[] arr = new int[] {1, 2, 3, 4, 5};
            
            Program p = new Program();
            p.rotate(arr);
            for(int i=0; i<5; i++)
            {
                Console.Write(arr[i] + " ");
            }
        }
    }
}










/***********************************
Solution in C++
***********************************/


//Solution-1
//Brute-Force Approach 
//S.C = O(1)
class Solution 
{
    public:
    void rotate(vector<int> &arr) 
    {
        int n = arr.size();
		int lastElement = arr[n-1];
		int temp = arr[0];
		for (int i=0; i<n-1; i++)
		{
			int temp1 = arr[i+1];
			arr[i+1] = temp;
			temp = temp1;
		}
		arr[0] = lastElement;
    }
};




//Solution-2
//S.C = O(1)
class Solution 
{
    public:
    void rotate(vector<int> &arr) 
    {
        reverse(arr.begin(), arr.end());
        reverse(arr.begin()+1, arr.end());
    }
};