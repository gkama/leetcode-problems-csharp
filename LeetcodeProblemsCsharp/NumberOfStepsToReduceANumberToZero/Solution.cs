// https://leetcode.com/problems/number-of-steps-to-reduce-a-number-to-zero/

public static class Solution
{
    public static int NumberOfSteps(int num)
    {
        if (num == 0) return num;

        var n = 0;

        while (num != 0)
        {
            if (num % 2 == 0) num = num / 2;
            else num = num - 1;

            n++;
        }

        return n;
    }
}
