public static class Solution
{
    /*
     * jewels is unique list of jewels
     * when you char array it then each one can be used as a reference
     * store the jewels in a dictionary and initiate them as 0 count
     * iterate through the stones and every time we see a stone, increment the jewels dict
     * complexity is not O(n * m), but rather O(n + m) - linear
     */
    public static int NumberOfStonesThatAreJewels(string jewels, string stones)
    {
        if (jewels == null || stones == null) return 0;

        // Put the jewels in a dictionary and store their index (starting at 0)
        var jewelsDictionary = new Dictionary<char, int>();

        foreach (var c in jewels)
        {
            if (!jewelsDictionary.ContainsKey(c))
            {
                jewelsDictionary.Add(c, 0);
            }
        }

        for (var i = 0; i < stones.Length; i++)
        {
            var stone = stones[i];

            if (jewelsDictionary.ContainsKey(stone))
            {
                jewelsDictionary[stone] += 1;
            }
        }

        // Return sum of all
        return jewelsDictionary.Sum(x => x.Value);
    }

    public static void Examples()
    {
        var exs = new Dictionary<string, string>
        {
            { "abc", "ac" },
            { "Af", "AaaddfFf" },
            { "AYOPD", "ayopd" },
            { "a", "abcabcabcabc" },
        };

        foreach (var ex in exs)
        {
            Console.WriteLine($"stones '{ex.Value}' that are jewels '{ex.Key}' -> {NumberOfStonesThatAreJewels(ex.Key, ex.Value)}");
        }
    }
}
