// https://leetcode.com/problems/non-overlapping-intervals/
public static class Solution
{
    public static int EraseOverlapIntervals(int[][] intervals)
    {
        if (intervals.Length == 0) return 0;

        Array.Sort(intervals, (x, y) => x[1].CompareTo(y[1]));

        var result = 0;
        var end = intervals[0][1];

        for (int i = 1; i < intervals.Length; i++)
        {
            if (intervals[i][0] >= end) end = intervals[i][1];
            else result++;
        }

        return result;
    }
}