public static class Solution
{
    public static bool IsPalindrome(string s)
    {
        if (string.IsNullOrWhiteSpace(s)) return true;

        // Strip s
        var sTrippedList = new List<char>();
        for (var i = 0; i < s.Length; i++)
        {
            var sCharLower = char.ToLower(s[i]);
            if (IsLetter(sCharLower))
            {
                sTrippedList.Add(sCharLower);
            }
        }

        // Iterate from start and end
        var sTrippedArray = sTrippedList.ToArray();
        var j = sTrippedArray.Length - 1;
        for (var i = 0; i < sTrippedArray.Length; i++)
        {
            if (sTrippedArray[i] != sTrippedArray[j]) return false;
            j--;
        }

        return true;
    }

    private static bool IsLetter(char c)
    {
        return "abcdefghijklmnopqrstuvwxyz".Contains(c);
    }

    public static void Examples()
    {
        var exs = new List<string>
        {
            "level",
            "algorithm",
            "A man, a plan, a canal: Panama."
        };

        foreach (var ex in exs)
        {
            Console.WriteLine($"{ex} -> {IsPalindrome(ex)}");
        }
    }
}
