// https://leetcode.com/problems/implement-strstr/
public class Solution
{
    public static int StrStr(string haystack, string needle)
    {
        /*
         * return index of the first occurrence of needle in haystack
         * or -1 if needle is not part of haystack
         * 0 when needle is an empty string
         * 
         * Alg
         *      hello -> ll
         *      hello -> op
         */
        if (string.IsNullOrEmpty(needle)) return 0;
        else if (string.IsNullOrEmpty(haystack)) return -1;
        // What if they're both null or empty? Does that mean that needle is in the haystack

        var needleFirstLetter = needle[0];
        var needleLength = needle.Length;
        var haystackLength = haystack.Length;

        for (var i = 0; i < haystack.Length; i++)
        {
            if (haystack[i] == needleFirstLetter)
            {
                if (needleLength > haystackLength - i)
                { 
                    return -1;
                }
                else if (needle == haystack.Substring(i, needleLength))
                {
                    return i;
                }
            }
        }

        return -1;
    }
}
