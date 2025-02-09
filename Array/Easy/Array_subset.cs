//Array Subset
/*
Input: a[] = [11, 7, 1, 13, 21, 3, 7, 3], b[] = [11, 3, 7, 1, 7]
Output: true
Explanation: b[] is a subset of a[]
*/





/**********************************
Solution in C#
**********************************/

using System;
using System.Collections.Generic;
namespace Demo
{
    class Program
    {
        public static bool IsSubset(List<int> a, List<int> b)
        {
            Dictionary<int, int> mp = new Dictionary<int, int>();
            foreach (int num in a)
            {
                if (mp.ContainsKey(num))
                    mp[num]++;
                else
                    mp[num] = 1;
            }

	    //print
	    /*
	    foreach (KeyValuePair<int, int> i in dict)
            {
                Console.WriteLine("Key: {0}, Value: {1}", i.Key, i.Value);
            }
	    */
			
            // Check each element in 'b'
            foreach (int num in b)
            {
                if (mp.ContainsKey(num) && mp[num] > 0)
                {
                    mp[num]--;
                }
                else
                {
                    return false;
                }
            }
            return true;
        }

        public static void Main(string[] args)
        {
            List<int> a = new List<int> {1, 7, 1, 13, 21, 3, 7, 3};
            List<int> b = new List<int> {11, 3, 7, 1, 11};
            bool result = IsSubset(a, b);
            Console.WriteLine(result);
        }
    }
}










/**********************************
Solution in C++
**********************************/

bool isSubset(vector<int> &a, vector<int> &b) 
{
    //using Hashing
    int n1 = a.size();
    unordered_map<int, int> mp;
    for(int i=0; i<n1; i++)
    {
        if(mp.find(a[i]) != mp.end())
        {
            mp[a[i]]++;
        }
        else
        {
            mp[a[i]] = 1;
        }
    }
    
    //print
    /*
    for(auto i = mp.begin(); i != mp.end(); i++)
    {
        cout << i->first << " " << i->second << endl;
    }
    */

    
    int n2 = b.size();
    for(int i=0; i<n2; i++)
    {
        if(mp[b[i]] > 0) {
            mp[b[i]]--;
        }
        else
        {
            return false;
        }
    }
    return true;
}
