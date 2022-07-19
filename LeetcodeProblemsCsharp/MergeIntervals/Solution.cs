// https://leetcode.com/problems/merge-intervals/
public static class Solution
{
    /*
    merging takes the first interval num at pos 0 and the second interval num at pos 1
    */
    public static int[][] Merge(int[][] intervals)
    {
        return MergeV2(intervals);
    }

    private static int[][] MergeV1(int[][] intervals)
    {
        var result = new List<List<int>>();
        var intervalsLength = intervals.Length;

        if (intervalsLength == 1)
            return intervals;

        var indexI = 0;
        var indexJ = intervalsLength - 1;

        while (indexI <= indexJ)
        {
            if (intervals[indexI][1] >= intervals[indexJ][0]) // Overlap
            {
                // Add it to result
                result.Add(new List<int> { Math.Min(intervals[indexI][0], intervals[indexJ][0]),
                                          Math.Max(intervals[indexJ][1], intervals[indexI][1]) });
                indexI = indexJ + 1;

                Console.WriteLine($"index i = {indexI}");
                Console.WriteLine($"index j = {indexJ}");
            }
            else
            {
                result.Add(new List<int> { intervals[indexJ][0], intervals[indexJ][1] });
                indexJ--;
            }
        }

        var toReturn = new int[result.Count()][];
        var resultArray = result.ToArray();

        for (var k = 0; k < toReturn.Length; k++)
        {
            toReturn[k] = resultArray[k].ToArray();
        }

        return toReturn;
    }

    private static int[][] MergeV2(int[][] intervals)
    {
        if (intervals == null || intervals.Length == 0 || intervals.Length == 1)
            return intervals;

        List<int[]> res = new List<int[]>();

        intervals = intervals.OrderBy(x => x[0]).ToArray();

        int s = intervals[0][0],
            e = intervals[0][1];

        for (int i = 1; i < intervals.Length; i++)
        { 
            if (intervals[i][0] > e)
            {
                res.Add(new int[] { s, e });
                s = intervals[i][0];
                e = intervals[i][1];
            }
            else
            {
                e = Math.Max(e, intervals[i][1]);
            }
        }

        res.Add(new int[] { s, e });

        return res.ToArray();
    }
}