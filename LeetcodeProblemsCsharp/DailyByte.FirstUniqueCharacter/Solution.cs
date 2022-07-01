/*
 * This question is asked by Microsoft. 
 * Given a string, return the index of its first unique character. 
 * If a unique character does not exist, return -1.
 */
public static class Solution
{
    #region Sol 1
    public static int FirstUniqueCharacter(string s)
    {
        if (string.IsNullOrWhiteSpace(s)) return -1;

        var dict = new Dictionary<char, NumberOfTimesAndIndex>();
        var sCharArray = s.ToCharArray();

        for (var i = 0; i < sCharArray.Length; i++)
        {
            var value = sCharArray[i];

            if (!dict.ContainsKey(value))
            {
                dict.Add(value, new NumberOfTimesAndIndex { Index = i, NumberOfTimes = 1 });
            }
            else if (dict.ContainsKey(value))
            {
                dict[value].NumberOfTimes += 1;
            }
        }

        var firstUnique = dict.OrderBy(x => x.Value.Index)
            .FirstOrDefault(x => x.Value.NumberOfTimes == 1);
        
        return firstUnique.Value == null ? -1 : firstUnique.Value.Index;
    }

    private class NumberOfTimesAndIndex
    {
        public int Index { get; set; }
        public int NumberOfTimes { get; set; }
    }
    #endregion

    #region Sol 2
    public static int FirstUniqueCharacter2(string s)
    {
        if (string.IsNullOrWhiteSpace(s)) return -1;

        var sCharArray = s.ToCharArray();

        for (var i = 0; i < sCharArray.Length; i++)
        {
            var value = sCharArray[i];
            var doesAtLeastSecondValueExist = false;

            for (var j = i + 1; j < sCharArray.Length; j++)
            {
                if (value == sCharArray[j])
                {
                    doesAtLeastSecondValueExist = true;
                    break;
                }
            }

            if (doesAtLeastSecondValueExist == false)
            {
                return i;
            }
        }

        return -1;
    }
    #endregion

    public static void Examples()
    {
        var exs = new List<string>
        {
            "abcabd",
            "thedailybyte",
            "developer"
        };

        foreach (var ex in exs)
        {
            Console.WriteLine($"{ex} -> {FirstUniqueCharacter2(ex)}");
        }
    }
}