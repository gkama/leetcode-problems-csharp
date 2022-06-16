// https://leetcode.com/problems/climbing-stairs/
public static class Solution
{
    /*
    Alg
        fibonacci seq of n + 1
        fibonacci seq
            0
            0, 1
            0, 1, 1
            0, 1, 1, 2
            0, 1, 1, 2, 3
            
        can use DP to store the previous Fibonnaci so it doesn't calculate it each time
    */
    public static int ClimbStairs(int n)
    {
        int[] fibonacciArray = new int[n + 1];

        for (int i = 0; i < n + 1; i++)
        {
            fibonacciArray[i] = -1;
        }

        Fibonacci(fibonacciArray, n);

        return fibonacciArray[n];
    }

    private static int Fibonacci(int[] fibonacciArray, int n)
    {
        if (n <= 1)
        {
            return fibonacciArray[n] = 1;
        }

        if (fibonacciArray[n] != -1)
        {
            return fibonacciArray[n];
        }

        fibonacciArray[n] = Fibonacci(fibonacciArray, n - 1) + Fibonacci(fibonacciArray, n - 2);

        return fibonacciArray[n];
    }
}