// https://leetcode.com/problems/add-digits/

public static class Solution
{
    public static int AddDigits(int num)
    {
        return AddDigitsRecursive(num);
    }

    private static int AddDigitsRecursive(int num)
    {
        if (num < 10) return num;

        var numStr = num.ToString();
        var digitTotal = 0;

        foreach (var digit in numStr)
        {
            digitTotal += int.Parse(digit.ToString());
        }

        return AddDigitsRecursive(digitTotal);
    }
}