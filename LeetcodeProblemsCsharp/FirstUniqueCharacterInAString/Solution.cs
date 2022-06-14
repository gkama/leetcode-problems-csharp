public static class Solution
{
    /*
    Alg
        O(n)
        class that stores index and count
        dictionary with letter and index, count
    */
    public class IndexCount
    {
        public int Count { get; set; }
        public int Index { get; set; } // Of first time we saw it
    }

    public static int FirstUniqChar(string s)
    {
        var dict = new Dictionary<char, IndexCount>();

        for (var i = 0; i < s.Length; i++)
        {
            if (!dict.ContainsKey(s[i])) // Add it
            {
                dict.Add(s[i], new IndexCount
                {
                    Count = 1,
                    Index = i
                });
            }
            else
            {
                dict[s[i]].Count += 1;
            }
        }

        // Return lowest index where count = 1
        var res = dict.OrderBy(x => x.Value.Index)
            .FirstOrDefault(x => x.Value.Count == 1)
            .Value;

        return res == null ? -1 : res.Index;
    }
}