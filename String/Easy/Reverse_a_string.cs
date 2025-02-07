//Reverse a String 
/*
Input: "Geeks"
Output: "skeeG"
*/







/*************************
Solution in C#
**************************/
using System;
namespace Demo
{
	class Program
	{
		public static string reverseString(string input)
		{
			//Since string is immutable in C#
			//First convert input string into char array
			char[] charArr = input.ToCharArray();
			Array.Reverse(charArr);
			return new String(charArr);
		}
		
		public static void Main(string[] args)
		{
			Console.Write("Input string: ");
			string input = Console.ReadLine();
			string output = reverseString(input);
			Console.WriteLine("Output string: " + output);
		}
	}
}









/**************************************************
Solution in C++
Approach:
	1. by creating new string and iterating thru it.
	2. in-place reversal.
**************************************************/


//Soltuion-1:
class Solution 
{
    public:
    string reverseString(string& s) 
    {
        //Code here
        string res;		//Extra space
        for(int i=s.length()-1; i>=0; i--) {
            res += s[i];
        }
        s = res;
        return s;
    }
};




//Solution-2:
string reverseString(string& s)
{
    //code here
    int n = s.length();
    int start = 0;
    int end = n-1;
    while(start < end)
    {
        char ch = s[start];
        s[start] = s[end];
        s[end] = ch;
        start++;
        end--;
    }
    return s;
};