//Bit Difference
/*
Input: a = 10, b = 20
Output: 4
Explanation:
a  = 01010
b  = 10100
As we can see, the bits of A that need to be flipped are 01010. If we flip these bits, we get 10100, which is B.
*/




/******************
Solution in C#
******************/


//Solution-1
using System;
namespace Demo
{
    class Program
    {
        public static int countBitsFlip(int a, int b)
        {
            int x = a^b;
            int count=0;
            while(x!=0)
            {
                if(x%2 != 0)
                    count++;
                x=x/2;
            }
            return count;
        }
        
        public static void Main(string[] args)
        {
            int a = 10;
            int b = 20;
            Console.WriteLine(countBitsFlip(a,b));
        }
    }
}





//Solution-2
using System;
namespace Demo
{
    class Program
    {
        public static int countBitsFlip(int a, int b)
        {
            int count=0;
            while(a!=0 || b!=0)
            {
                if((a&1) != (b&1))
                    count++;
                a = a >> 1;
                b = b >> 1;
            }
            return count;
        }
        
        public static void Main(string[] args)
        {
            int a = 10;
            int b = 20;
            Console.WriteLine(countBitsFlip(a,b));
        }
    }
}