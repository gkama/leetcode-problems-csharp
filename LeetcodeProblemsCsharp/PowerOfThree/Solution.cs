// https://leetcode.com/problems/power-of-three/
public static class Solution
{
    public static bool IsPowerOfThree(int n)
    {
        for (var i = 0; i < n; i++)
        {
            var value = Math.Pow(3, i);

            if (value == n) return true;
            else if (value > n) return false;
        }

        return false;
    }
}
