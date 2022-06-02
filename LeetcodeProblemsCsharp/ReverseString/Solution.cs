using System.Text;


/*
 * Given a string s and an integer k, reverse the first k characters for every 2k characters counting from the start of the string.
 * there are fewer than k characters left, reverse all of them. If there are less than 2k but greater than or equal to k characters, 
 * then reverse the first k characters and leave the other as original.
*/
public static class Solution
{
    public static string ReverseStr(string s, int k)
    {
        if (s.Length <= k) return ReverseSubString(s);

        // Split the string in the k and 2k substrings
        var twok = 2 * k;
        var len = s.Length;
        var substrings = new List<string>();

        for (var i = 0; i < s.Length; i += twok)
        {
            var endingLength = i + twok > len ? len - i : twok;

            var substring = s.Substring(i, endingLength);
            var substringLen = substring.Length;


            if (substringLen <= k)
            {
                substrings.Add(ReverseSubString(substring));
            }
            else if (substringLen == twok)
            {
                substrings.Add(ReverseSubString(substring.Substring(0, k)));
                substrings.Add(substring.Substring(0 + k, k));
            }
            else if (substringLen < twok && substringLen >= k)
            {
                substrings.Add(ReverseSubString(substring.Substring(0, k)));
                substrings.Add(substring.Substring(0 + k, substringLen - k));
            }
            else
            {
                substrings.Add(substring);
            }
        }

        return string.Join(string.Empty, substrings.ToArray());
    }

    private static string ReverseSubString(string s)
    {
        var charArray = s.ToCharArray();

        Array.Reverse(charArray);

        return new string(charArray);
    }
}
