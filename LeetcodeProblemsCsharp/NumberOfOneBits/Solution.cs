// https://leetcode.com/problems/number-of-1-bits/
public static class Solution
{
    public static int HammingWeight(uint n)
    {
        var nBinary = Convert.ToString(n, 2);
        var total = 0;

        for (var i = 0; i < nBinary.Length; i++)
        {
            if (nBinary[i] == '1') total += 1;
        }

        return total;
    }
}