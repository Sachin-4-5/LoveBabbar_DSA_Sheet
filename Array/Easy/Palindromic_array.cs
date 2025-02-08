//Palindromic Array
//A palindromic number is one that reads the same forward and backward.
/*
Input: arr[] = [111, 222, 333, 444, 555]
Output: true
*/




/***********************************
Solution in C#
***********************************/

using System;
namespace Demo
{
    class Program
    {
        public bool isPalindrome(int num)
        {
            int temp = num;
            int revNum = 0;
            while(temp > 0)
            {
                int rem = temp%10;
                revNum = revNum*10 + rem;
                temp = temp/10;
            }
            return (num==revNum) ? true : false;
        }
        
        public bool isPalinArray(int[] arr)
        {
            int n = arr.Length;
            bool ans = true;
            for(int i=0; i<n; i++)
            {
                if(!isPalindrome(arr[i]))
                {
                    ans=false;
                    break;
                }
            }
            return ans;
        }
        
        public static void Main(string[] args)
        {
            int n = 5;
            int[] arr = new int[] {111, 222, 333, 444, 555};
            
            Program p = new Program();
            Console.WriteLine(p.isPalinArray(arr));
        }
    }
}









/******************************
Solution in C++
******************************/

//T.C = O(N*LOG(N))
class Solution 
{
    public:
    bool isPalindrome(int num)
    {
        int temp = num;
        int revNum = 0;
        while(temp > 0)
        {
            int rem = temp%10;
            revNum = revNum*10 + rem;
            temp = temp/10;
        }
        return (num == revNum) ? true: false;
    }
    
    bool isPalinArray(vector<int> &arr) 
    {
        // code here
        int n = arr.size();
        bool ans = true;
        for(int i=0; i<n; i++)
        {
            if(!isPalindrome(arr[i])) {
                ans = false;
                break;
            }
        }
        return ans;
    }
};