// https://leetcode.com/problems/power-of-two/
public static class Solution
{
    public static bool IsPowerOfTwoV2(int n)
    {
        if (n == 1) return true;

        var max = 31;
        var i = 0;

        while (i <= max)
        {
            if (Math.Pow(2, i) == n) return true;
            i++;
        }

        return false;
    }

    public static bool IsPowerOfTwoV1(int n)
    {
        if (n == 1) return true;

        while (n > 1)
        {
            n = n / 2;
        }

        return n == 0;
    }
}