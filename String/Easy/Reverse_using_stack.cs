//Reverse a string using stack

/*
Input: S="GeeksforGeeks"
Output: skeeGrofskeeG
*/





/********************
solution in c#
********************/

using System;
using System.Collections.Generic;
using System.Text;
namespace demo
{
    class program
    {
        public static string reverse(string s)
        {
            StringBuilder sb = new StringBuilder("");
            Stack<char> st = new Stack<char>();
            for(int i=0; i<s.Length; i++)
            {
                st.Push(s[i]);
            }
            
            while(st.Count > 0)
            {
                sb.Append(st.Peek());
                st.Pop();
            }
            return sb.ToString();
        }
        
        public static void Main(string[] args)
        {
            string s = "Raman";
            Console.WriteLine(reverse(s));
        }
    }
}






/********************
solution in c++
********************/

char* reverse(char *s, int len)
{
    //code here
    stack<char> st;
    for(int i=0; i<strlen(s); i++)
    {
        st.push(s[i]);
    }
    
    int index=0;
    while(!st.empty())
    {
        s[index] = st.top();
        st.pop();
        index++;
    }
    
    return s;
}