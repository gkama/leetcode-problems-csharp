// https://leetcode.com/problems/sqrtx/
public class Solution
{
    /*
     * Alg
     *      subtraction method
     *          We subtract the consecutive odd numbers from the number for which we are finding the square root, 
     *          till we reach 0. The number of times we subtract is the square root of the given number. 
     *          This method works only for perfect square numbers
     */
    public static int MySqrt(int x)
    {
        if (x == 0) return 0;

        var sqrt = 0;
        var sum = x;
        var i = 1;

        while (sum >= 0)
        {
            if (i % 2 == 1) // odd
            {
                sum -= i;
                sqrt += 1;
            }

            i++;
        }

        return sqrt - 1;
    }
}
