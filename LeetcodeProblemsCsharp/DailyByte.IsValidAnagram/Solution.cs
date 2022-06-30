public static class Solution
{
    public static bool IsValidAnagram(string s, string t)
    {
        // Is t a valid anagram of s
        // O(n), n being the length of s
        if (s == null && t == null) return true;
        if (s!.Length != t!.Length) return false;

        var dictS = new Dictionary<char, int>();
        var dictT = new Dictionary<char, int>();

        for (var i = 0; i < s.Length; i++)
        {
            var si = s[i];
            var ti = t[i];

            if (dictS.ContainsKey(si)) dictS[si] += 1;
            else if (!dictS.ContainsKey(si)) dictS.Add(si, 1);

            if (dictT.ContainsKey(ti)) dictT[ti] += 1;
            else if (!dictT.ContainsKey(ti)) dictT.Add(ti, 1);
        }

        // Dictionaries need to be the same size
        // and they need to have the same amount of letters
        if (dictS.Count() != dictT.Count()) return false;

        foreach (var kv in dictS)
        {
            if (!dictT.ContainsKey(kv.Key)) return false;
            if (dictS[kv.Key] != dictT[kv.Key]) return false;
        }

        return true;
    }

    public static void Examples()
    {
        var exs = new Dictionary<string, string>
        {
            { "cat", "tac" },
            { "listen", "silent" },
            { "program", "function" }
        };

        foreach (var ex in exs)
        {
            Console.WriteLine($"{ex.Key} and {ex.Value} -> {IsValidAnagram(ex.Key, ex.Value)}");
        }
    }
}
