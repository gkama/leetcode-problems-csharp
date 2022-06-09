// https://leetcode.com/problems/length-of-last-word/
public class Solution
{
    /*
     * Alg
     *      trim end string
     *      split into array based on " "
     *      return last one's length
     */
    public static int LengthOfLastWord(string s)
    {
        var trimmed = s.Trim();
        var split = trimmed.Split(' ');
        var splitLast = split[split.Length - 1];
        var len = splitLast.Length;

        return len;
    }

    public static int LengthOfLastWord2(string s)
    {
        var split = s.Split(' ').ToHashSet();
        var len = split.Last(x => !string.IsNullOrWhiteSpace(x)).Length;

        return len;
    }
}
