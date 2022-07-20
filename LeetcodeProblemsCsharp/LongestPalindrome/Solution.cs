// https://leetcode.com/problems/longest-palindrome/
public static class Solution
{
    public static int LongestPalindrome(string s)
    {
        if (s == null || s.Length == 0)
            return 0;

        int len = 0;
        var set = new HashSet<char>();

        foreach (var c in s)
        {
            if (set.Contains(c))
            {
                len += 2;
                set.Remove(c);
            }
            else
            {
                set.Add(c);
            }
        }

        return set.Count > 0 ? len + 1 : len;
    }
}