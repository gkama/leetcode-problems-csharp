//https://leetcode.com/problems/palindrome-number/
public static class Solution
{
    public static bool IsPalindrome(int x)
    {
        var xStr = x.ToString();

        if (x == 0 || xStr.Count() == 1)
        {
            return true;
        }
        else if (xStr.Count() == 2 || xStr.Count() == 3)
        {
            return xStr[0] == xStr[xStr.Length - 1];
        }

        var isEven = xStr.Length % 2 == 0;
        var half = xStr.Length / 2;
        var left = xStr.Substring(0, half);

        if (isEven)
        {
            var right = xStr.Substring(half, xStr.Length - half);

            return left == new string(right.Reverse().ToArray());
        }
        else
        {
            var right = xStr.Substring(half + 1, xStr.Length - (half + 1));

            return left == new string(right.Reverse().ToArray());
        }
    }
}
