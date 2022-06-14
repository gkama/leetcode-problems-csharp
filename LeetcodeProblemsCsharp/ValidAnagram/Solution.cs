public static class Solution
{
    /*
    Alg
        keep 2 dicts
        1 dict for s
        1 dict for t
        loop and check if each s appears n times in each
    */
    public static bool IsAnagram(string s, string t)
    {
        if (s.Length != t.Length) return false;

        var sDict = new Dictionary<char, int>();
        var tDict = new Dictionary<char, int>();

        // Populate them
        foreach (var ss in s)
        {
            if (sDict.ContainsKey(ss)) sDict[ss]++;
            else sDict.Add(ss, 1);
        }

        foreach (var tt in t)
        {
            if (tDict.ContainsKey(tt)) tDict[tt]++;
            else tDict.Add(tt, 1);
        }

        // Check if each letter exists n times in both
        foreach (var kv in sDict)
        {
            if (!tDict.ContainsKey(kv.Key)) return false;
            else if (tDict[kv.Key] != kv.Value) return false;
        }

        return true;
    }
}



