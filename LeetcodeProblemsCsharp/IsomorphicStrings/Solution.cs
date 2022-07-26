// https://leetcode.com/problems/isomorphic-strings/
public static class Solution
{
    public static bool IsIsomorphic(string s, string t)
    {
        var map = new Dictionary<char, char>();

        for (var i = 0; i < s.Length; i++)
        {
            if (map.ContainsKey(s[i]) && map[s[i]] == t[i])
            {
                continue;
            }
            else if (map.ContainsKey(s[i]) && map[s[i]] != t[i])
            {
                return false;
            }
            else if (!map.ContainsKey(s[i]) && map.ContainsValue(t[i]))
            {
                return false;
            }
            else
            {
                map.Add(s[i], t[i]);
            }
        }

        return true;
    }
}