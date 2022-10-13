/*
 * Given a string s, reverse the words.
 * Note: You may assume that there are no leading or trailing whitespaces and each word within s is only separated by a single whitespace.
 * 
 * Ex: Given the following string s…
 * s = "The Daily Byte", return "Byte Daily The".
 */
public static class Solution
{
    public static string SwapWords(string s)
    {
        if (string.IsNullOrWhiteSpace(s)) return s;

        var sSplit = s.Split(' ');
        var sSplitSize = sSplit.Length;
        var sReversed = new System.Text.StringBuilder();

        for (var i = sSplitSize - 1; i >= 0; i--)
        {
            sReversed.Append(sSplit[i]);

            if (i != 0) sReversed.Append(' ');
        }

        return sReversed.ToString();
    }

    public static void Examples()
    {
        var exs = new List<string>
        {
            "The Daily Byte",
            "Testing The Reverse"
        };

        foreach (var ex in exs)
        {
            Console.WriteLine($"{ex} -> {SwapWords(ex)}");
        }
    }
}
