//Evaluate the expression

/*
Given a number n, find the value of below expression:
f(n-1)*f(n+1) - f(n)*f(n), where f(n) is nth Fibonacci. 
 
Input : n = 5
Output: -1
Explanation: f(4) = 3, f(5) = 5
f(6) = 8. 3 * 8 - 5 * 5 = -1
*/



//Explaination:
//Fibonacci Series: 1, 1, 2, 3, 5, 8, 13, 21, 34, ..soon


//Solution in C#
//Naive approach
//T.C = O(log(n))
using System;
namespace Demo
{
	class Program
	{
		//Nth fibonacci number 
		public int fib(int n)
		{
			int first = 1;
			int second = 1;
			int curr = 0;
			
			if(n==1 || n==2)
				return 1;
			
			while(n > 2)
			{
				curr = first + second;
				first = second;
				second = curr;
				n--;
			}
			return curr;
		}
		
		public static int evaluate_exp(int n)
		{
			return (fib(n-1) * fib(n+1)) - (fib(n)*fib(n));
		}
		
		public static void Main(string[] args)
		{
			int num = Convert.ToInt32(Console.Readline());
			int ans = evaluate_exp(num);
			Console.WriteLine(ans);
		}
	}
}





//Optimize soln
//T.C = S.C = O(1)
//f(n-1)*f(n+1) - f(n)*f(n) = (-1)^n known as  Cassini's identity.
using System;
namespace Demo
{
	class Program
	{
		public class int evaluate_exp(int n)
		{
			return Convert.ToInt32(Math.Pow(-1, n));
		}
	}
}