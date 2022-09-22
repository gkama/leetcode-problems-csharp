/*
 * This question is asked by Amazon. Given a string s remove all the vowels it contains and return the resulting string.
 * Note: In this problem y is not considered a vowel.
 * 
 * Ex: Given the following string s…
 * s = "aeiou", return ""
 */
using System.Collections.Generic;
using System.Text;

public static class Solution
{
    private static List<char> _vowels = new List<char> { 'a', 'e', 'i', 'o', 'u' };

    public static string RemoveVowels(string s)
    {
        if (string.IsNullOrWhiteSpace(s)) return string.Empty;

        var sWithRemovedVowels = new StringBuilder();

        foreach (var c in s)
        {
            if (!_vowels.Contains(c)) sWithRemovedVowels.Append(c);
        }

        return sWithRemovedVowels.ToString();
    }

    public static void Examples()
    {
        var exs = new List<string>
        {
            "aeiou",
            "byte",
            "daily",
            "xyz",
            "aaaaaaeeeeoooib"
        };

        foreach (var ex in exs)
        {
            Console.WriteLine($"{ex} -> {RemoveVowels(ex)}");
        }
    }
}
