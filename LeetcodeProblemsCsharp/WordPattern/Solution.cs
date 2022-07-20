// https://leetcode.com/problems/word-pattern/
public static class Solution
{
    public static bool WordPattern(string pattern, string s)
    {
        if (pattern == null) return true;
        if (s == null) return false;

        var sArray = s.Split(' ');

        if (pattern.Length != sArray.Length) return false;

        var dict = new Dictionary<string, string>();

        for (var i = 0; i < sArray.Length; i++)
        {
            var word = sArray[i];
            var patternLetter = pattern[i].ToString();

            if (dict.ContainsKey(patternLetter))
            {
                if (dict[patternLetter] != word) return false;
            }
            else
            {
                if (dict.ContainsValue(word)) return false;

                dict.Add(patternLetter, word);
            }
        }

        return true;
    }
}