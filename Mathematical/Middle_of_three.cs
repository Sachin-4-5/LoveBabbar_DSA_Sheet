//Middle Of Three
/*
Input: a = 978, b = 518, c = 300
Output: 518
Explanation: Since 518>300 and 518<978, so 518 is the middle element.
*/




//T.C = O(1)
//S.C = O(1)
using System;
namespace Demo
{
	class Program
	{
		int middle(int a, int b, int c) 
		{
			//code here
			if(a<=b && b<=c || (c<=b && b<=a))
				return b;
			else if((b<=a && a<=c) || (c<=a && a<=b))
				return a;
			return c;
		}
	}