/*
 * This question is asked by Amazon. Given two strings representing sentences, 
 * return the words that are not common to both strings (i.e. the words that only appear in one of the sentences). 
 * You may assume that each sentence is a sequence of words (without punctuation) correctly separated using space characters.
 */
public static class Solution
{
    /*
     * Alg
     *  create a dict to store the words and count of each one
     *  return only ones that have count of 1
     *  
     *  option 2 is 
     *  split it, order it then iterate through the smaller one
     */
    public static List<string> UncommonWords(string s1, string s2)
    {
        var result = new Dictionary<string, int>();

        if (string.IsNullOrWhiteSpace(s1) && string.IsNullOrWhiteSpace(s2)) return new List<string>();

        var s1Split = s1.Split(' ');
        var s2Split = s2.Split(' ');
        var s1Size = s1Split.Length;
        var s2Size = s2Split.Length;

        void CheckResult(string w1, string w2)
        {
            if (!string.IsNullOrWhiteSpace(w1))
            {
                if (!result.ContainsKey(w1)) result.Add(w1, 1);
                else if (result.ContainsKey(w1)) result[w1] += 1;
            }
            
            if (!string.IsNullOrWhiteSpace(w2))
            {
                if (!result.ContainsKey(w2)) result.Add(w2, 1);
                else if(result.ContainsKey(w2)) result[w2] += 1;
            }
        }

        // 3 cases, s1Size is bigger, s2Size is bigger, or equal
        if (s1Size > s2Size)
        {
            for (var i = 0; i < s2Size; i++)
            {
                CheckResult(s1Split[i], s2Split[i]);
            }

            // Now we're left with the remainder of s1split
            for (var j = s2Size - 1; j < s1Size; j++)
            {
                CheckResult(s1Split[j], null);
            }
        }
        else if (s2Size > s1Size)
        {
            for (var i = 0; i < s1Size; i++)
            {
                CheckResult(s1Split[i], s2Split[i]);
            }

            // Now we're left with the remainder of s2split
            for (var j = s1Size - 1; j < s2Size; j++)
            {
                CheckResult(null, s2Split[j]);
            }
        }
        else
        {
            for (var i = 0; i < s1Size; i++)
            {
                CheckResult(s1Split[i], s2Split[i]);
            }
        }

        // Return
        return result.Where(x => x.Value == 1)
            .Select(x => x.Key)
            .ToList();
    }

    public static void Examples()
    {
        var exs = new Dictionary<string, string>
        {
            { "the quick", "brown fox" },
            { "the tortoise beat the haire", "the tortoise lost to the haire" },
            { "copper coffee pot", "hot coffee pot" }
        };

        foreach (var ex in exs)
        {
            Console.WriteLine($"'{ex.Key}' and '{ex.Value}' -> {string.Join(", ", UncommonWords(ex.Key, ex.Value))}");
        }
    }
}
