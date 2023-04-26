/*
 * You are given a list of intervals as a two dimensional matrix. Each interval contains two values, first a start time and second an end time. 
 * An interval [a, b] is “covered” by another interval [c, d] if and only if c <= a and b <= d. Given these intervals, return the count of intervals that are not covered by any other interval.
 * 
 * Ex: Given the following intervals…
 * intervals = [[1, 2], [0, 4]], return 1 ([0, 4] is the only remaining interval).
 * 
 * Ex: Given the following intervals…
 * intervals = [[8, 10], [4, 6], [1, 2]], return 3.
 */

public static class Solution
{
    public static int RemainingIntervals(int[][] intervals)
    {
        var count = 0;

        Array.Sort(intervals, (x, y) => x[1].CompareTo(y[1]));

        for (var i = 0; i < intervals.Length; i++)
        {
            var isInInterval = true;

            for (var j = i + 1; j < intervals.Length; j++)
            {
                // Compare intervals
                isInInterval = intervals[j][0] <= intervals[i][0] && intervals[i][1] <= intervals[j][1];
            }

            if (!isInInterval) count++;
        }

        return count + 1;
    }

    public static void Examples()
    {
        var exs = new List<int[][]>
        {
           new int[][] { new int[] { 1, 2 }, new int[] { 0, 4 } },
           new int[][] { new int[] { 8, 10 }, new int[] { 4, 6 }, new int[] { 1, 2 } },
           new int[][] { new int[] { 1, 2 }, new int[] { 3, 4 }, new int[] { 0, 10 } }
        };

        foreach (var ex in exs)
        {
            var listOfArrays = new List<string>();
            foreach (var arr in ex) listOfArrays.Add($"[{string.Join(',', arr)}]");

            Console.WriteLine($"[{string.Join(' ', listOfArrays)}] return {RemainingIntervals(ex)}");
        }
    }
}