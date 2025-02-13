//Find position of set bit
/*
Input: n = 2
Output: 2
Explanation: 2 is represented as "10" in Binary. As we see there's only one set bit and it's in position 2.
*/





/***********************
Solution in c#
***********************/


//Solution-1
using System;
namespace demo
{
    class Program
    {
        public static int findPosition(int n)
        {
            if(n==0) return -1;
            int count=0;
            int pos=0;
            while(n!=0)
            {
                if((n&1) == 1) {
                    count++;
                    if(count>1) return -1;
                }
                pos++;
                n = n>>1;
            }
            return pos;
        }
        
        public static void Main(string[] args)
        {
            int n = 2;
            Console.WriteLine(findPosition(n));
        }
    }
}





//Solution-2
using System;
namespace demo
{
    class Program
    {
        public static int findPosition(int n)
        {
            if (n == 0 || (n & (n - 1)) != 0)
				return -1;
            return (int)Math.Log(n, 2) + 1;
        }
        
        public static void Main(string[] args)
        {
            int n = 2;
            Console.WriteLine(findPosition(n));
        }
    }
}