// https://leetcode.com/problems/valid-palindrome/
public class Solution
{
    private static string _alphaNumeric = "0123456789abcdefghijklmnopqrstuvwxyz";

    public bool IsPalindrome(string s)
    {
        if (s == null) return true;

        var indexLeft = 0;
        var indexRight = s.Length - 1;

        while (indexLeft < indexRight)
        {
            var cLeft = s[indexLeft];
            var cRight = s[indexRight];

            if (IsAlphanumeric(cLeft) && IsAlphanumeric(cRight))
            {
                if (cLeft.ToString().ToLower() != cRight.ToString().ToLower()) return false;

                indexLeft++;
                indexRight--;
            }
            else if (IsAlphanumeric(cLeft) && !IsAlphanumeric(cRight))
            {
                indexRight--;
            }
            else if (!IsAlphanumeric(cLeft) && IsAlphanumeric(cRight))
            {
                indexLeft++;
            }
            else
            {
                indexLeft++;
                indexRight--;
            }
        }

        return true;
    }


    private bool IsAlphanumeric(char c)
    {
        return _alphaNumeric.Contains(c.ToString().ToLower());
    }
}