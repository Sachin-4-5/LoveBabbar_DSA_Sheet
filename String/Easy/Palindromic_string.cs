//Palindromic String

/*
Input: s = "abba"
Output: true
Explanation: "abba" reads the same forwards and backwards, so it is a palindrome.
*/





/***********************
Solution in C#
***********************/

using System;
namespace Demo
{
    class Program
    {
        public static bool isPalindrome(string s)
        {
            string temp = s;
            char[] arr = temp.ToCharArray();
            Array.Reverse(arr);
            
            return (s==new String(arr) ? true : false);
        }
        
        public static void Main(string[] args)
        {
            string s = "a";
            Console.WriteLine(isPalindrome(s));
        }
    }
}





/***********************
Solution in C++
***********************/

class Solution 
{
    public:
    bool isPalindrome(string& s) 
    {
        // code here
        string temp = s;
        reverse(temp.begin(), temp.end());
        return (temp == s);
    }
};
