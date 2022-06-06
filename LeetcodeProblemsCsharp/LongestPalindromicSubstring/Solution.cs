// https://leetcode.com/problems/longest-palindromic-substring/
public static class Solution
{
    public static string LongestPalindrome(string s)
    {
        if (string.IsNullOrEmpty(s) || s.Length <= 1) return s;
        else if (s.Length == 2 && s[0] == s[1]) return s;
        else if (s.Length == 2 && s[0] != s[1]) return s[0].ToString();
        else if (s.ToCharArray().Distinct().Count() == 1) return s;

        var palindromes = new Dictionary<string, int>();

        for (var i = 0; i < s.Length; i++)
        {
            var palindrome = new List<char> { s[i] };
            for (var j = i + 1; j < s.Length; j++)
            {
                palindrome.Add(s[j]);

                var palindromeStr = new string(palindrome.ToArray());

                if (!palindromes.ContainsKey(palindromeStr))
                {
                    var isPalindrome = IsPalindrome(palindromeStr);

                    if (isPalindrome)
                    {
                        palindromes.Add(palindromeStr, palindromeStr.Length);
                    }
                }
            }

        }

        var max = new KeyValuePair<string, int>();
        foreach (var p in palindromes)
        {
            if (p.Value > max.Value)
            {
                max = p;
            }
        }

        return palindromes.Count == 0 ? s[0].ToString() : max.Key;
    }

    private static bool IsPalindrome(string s)
    {
        // If divided in half
        // If odd (3, 5, etc.) length then ignore the middle one
        // If even (2, 4, etc.) the two halves must be mirrored
        var isEven = s.Length % 2 == 0;

        if (isEven)
        {
            var half = s.Length / 2;
            var left = s.Substring(0, half);
            var right = s.Substring(half, s.Length - half);

            return left.ToString() == new string(right.Reverse().ToArray());
        }
        else
        {
            var half = s.Length / 2;
            var left = s.Substring(0, half);
            var right = s.Substring(half + 1, s.Length - (half + 1));

            return left.ToString() == new string(right.Reverse().ToArray());
        }
    }
}
