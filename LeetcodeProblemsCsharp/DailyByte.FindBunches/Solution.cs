/*
 * Given a string S that contains only lowercase letters, return a list containing the intervals of all the bunches. 
 * A bunch is a set of contiguous characters (larger than two) that are all the same. An interval that represents a bunch contains the starting index of the bunch and the ending index of the bunch.
 * Note: The intervals returned should be in ascending order according to start indexes.
 * 
 * Given the following string S...
 * S = “aaabbbccc”, return [[0,2],[3,5],[6,8]].
 * 
 * Given the following string S...
 * S = “aaabbcddddd”, return [[0,2],[6,10]].
 */

public static class Solution
{
    public static List<int[]> FindBunches(string S)
    {
        var bunches = new List<int[]>();
        var next = S[0];
        var nextCount = 1;

        for (var i = 1; i < S.Length; i++)
        {

            if (next == S[i])
            {
                nextCount += 1;
            }
        }

        return bunches;
    }
}