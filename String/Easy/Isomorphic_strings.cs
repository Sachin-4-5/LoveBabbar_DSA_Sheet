//Isomorphic Strings

/*
Given two strings s1 and s2, check if these two strings are isomorphic to each other.
If the characters in s1 can be changed to get s2, then two strings, s1 and s2, are isomorphic. 
A character must be completely swapped out for another character while maintaining the order of the characters. 
A character may map to itself, but no two characters may map to the same character.

Examples - 
Input: s1 = "aab", s2 = "xxy"
Output: true
Explanation: There are two different characters in aab and xxy, i.e a and b with frequency 2 and 1 respectively.
*/





/***************************
Solution in C#
***************************/

using System;
using System.Collections.Generic;
class Program
{
    public static bool AreIsomorphic(string s1, string s2)
    {
        //base case
        if (s1.Length != s2.Length) return false;

        Dictionary<char, char> mp1 = new Dictionary<char, char>();
        Dictionary<char, char> mp2 = new Dictionary<char, char>();

        for (int i = 0; i < s1.Length; i++)
        {
            char c1 = s1[i];
            char c2 = s2[i];

            if (mp1.ContainsKey(c1))
            {
                if (mp1[c1] != c2) return false;
            }
            else
            {
                mp1[c1] = c2;
            }

            if (mp2.ContainsKey(c2))
            {
                if (mp2[c2] != c1) return false;
            }
            else
            {
                mp2[c2] = c1;
            }
        }
        return true;
    }

    public static void Main()
    {
        string s1 = "jmpdwrd", s2 = "tglkqyk";
        Console.WriteLine(AreIsomorphic(s1, s2) ? true : false);
    }
}










/***************************
Solution in C++
***************************/

bool areIsomorphic(string &s1, string &s2) 
{
    //base case
    if(s1.size() != s2.size())
        return false;
        
    unordered_map<char,char> mp1, mp2;
    for(int i=0; i<s1.size(); i++)
    {
        char c1 = s1[i];
        char c2 = s2[i];
        
        //case-1
        if(mp1.count(c1) > 0)
        {
            if(mp1[c1] != c2) return false;
        }
        else
        {
            mp1[c1] = c2;
        }
        
        
        //case-2
        if(mp2.count(c2) > 0)
        {
            if(mp2[c2] != c1) return false;
        }
        else
        {
            mp2[c2] = c1;
        }
    }
    return true;
}


