public static class Solution
{
    /*
    Alg
        random note's characters need to appear the same amount of times
        as in magazine
        
        option 1
            keep 2 dictionaries
            randomnote dictionary
            magazine dictionary
            each one has the letter and count
            loop and compare
    */
    public static bool CanConstruct(string ransomNote, string magazine)
    {
        var dictRansomNote = new Dictionary<char, int>();
        var dictMagazine = new Dictionary<char, int>();

        foreach (var r in ransomNote)
        {
            if (dictRansomNote.ContainsKey(r)) dictRansomNote[r]++;
            else dictRansomNote.Add(r, 1);
        }

        foreach (var m in magazine)
        {
            if (dictMagazine.ContainsKey(m)) dictMagazine[m]++;
            else dictMagazine.Add(m, 1);
        }

        // Check
        foreach (var kv in dictRansomNote)
        {
            if (!dictMagazine.ContainsKey(kv.Key)) return false;
            else if (dictMagazine[kv.Key] < dictRansomNote[kv.Key]) return false;
        }

        return true;
    }
}