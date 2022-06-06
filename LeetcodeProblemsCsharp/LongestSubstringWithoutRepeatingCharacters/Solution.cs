// https://leetcode.com/problems/longest-substring-without-repeating-characters/
public static class Solution
{
    public static int LengthOfLongestSubstring(string s)
    {
        if (string.IsNullOrEmpty(s)) return 0;

        var streaks = new List<int>();
        var streak = false;
        var total = 0;

        for (var i = 0; i < s.Length; i++)
        {
            var nonRepeatedChars = new HashSet<char>();
            nonRepeatedChars.Add(s[i]);
            total += 1;

            for (var j = i + 1; j < s.Length; j++)
            {
                if (!nonRepeatedChars.Contains(s[j]))
                {
                    nonRepeatedChars.Add(s[j]);
                    streak = true;
                }
                else
                {
                    streak = false;
                    streaks.Add(total);
                    total = 0;
                    break;
                }

                if (streak)
                {
                    total += 1;
                }

                if (streak && j == s.Length - 1) //Reached the end
                {
                    streak = false;
                    streaks.Add(total);
                    total = 0;
                }
            }
        }

        return streaks.Count == 0 ? 1 : streaks.Max();
    }
}
