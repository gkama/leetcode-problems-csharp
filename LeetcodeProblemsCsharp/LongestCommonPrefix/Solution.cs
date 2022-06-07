// https://leetcode.com/problems/longest-common-prefix/
using System.Linq;

public class Solution
{
    public static string LongestCommonPrefix(string[] strs)
    {
        /*
         * If no common prefix, return ""
         * prefix: starts at the beginning, so at position 0 to n
         *  if none, then return ""
         * 
         * Alg
         * - Order strings, smallest first (so we iterate the least)
         *  Now we know that there will at most be first string's length as common prefix
         * - Loop through the chars of the the first string and in parallel look at each subsequent string (for loop starting at 1 to length)
         * 
         * Example
         *  strs = ["flower","flow","flight"]
         *  sorted = ["flow","flower","flight"]
         *  [f],[f],[f] -> [l], [l],[l] -> [o],[o],[i] -> "fl"
         */

        // First check for quick exists
        if (strs == null || strs.Count() == 0) return "";
        else if (strs.Count() == 1) return strs[0];

        Array.Sort(strs);

        var first = strs[0];
        var longestCommonPrefix = new List<char>();

        for (var i = 0; i < first.Length; i++)
        {
            var charToCompare = first[i];
            var allMatch = false;

            for (var j = 1; j < strs.Length; j++)
            {
                if (charToCompare == strs[j][i])
                {
                    allMatch = true;
                }
                else
                {
                    allMatch = false;
                }
            }

            if (allMatch)
            {
                longestCommonPrefix.Add(charToCompare);
            }
            else
            {
                goto constructLongestCommonPrefix;
            }
        }

        constructLongestCommonPrefix: var prefix = string.Join("", longestCommonPrefix);

        return prefix;
    }
}
