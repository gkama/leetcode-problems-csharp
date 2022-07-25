// https://leetcode.com/problems/happy-number/
public static class Solution
{
    public static bool IsHappy(int n)
    {
        // 1. replace the number by the sum of the squares of its digits
        // 2. repeat until 1
        // 3. if not one, it's not happy
        var digits = n.ToString().ToCharArray();
        var sum = 0;
        var iterations = 0;

        while (sum != 1)
        {
            if (iterations >= 10) return false;

            sum = 0;

            foreach (var d in digits)
            {
                var dInt = int.Parse(d.ToString());
                sum += dInt * dInt;
            }

            if (sum == 1) goto readyToReturn;
            else digits = sum.ToString().ToCharArray();

            iterations += 1;
        }

        readyToReturn: return true;
    }
}