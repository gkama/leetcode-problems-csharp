// https://leetcode.com/problems/richest-customer-wealth/

public static class Solution
{
    public static int MaximumWealth(int[][] accounts)
    {
        var wealthiest = int.MinValue;
        var n = accounts.Length;

        for (var i = 0; i < n; i++)
        {
            var jN = accounts[i].Length;
            var sum = 0;

            for (var j = 0; j < jN; j++)
            {
                sum += accounts[i][j];
            }

            if (sum > wealthiest)
            {
                wealthiest = sum;
            }
        }

        return wealthiest;
    }
}
