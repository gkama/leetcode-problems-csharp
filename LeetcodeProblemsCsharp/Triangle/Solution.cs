// https://leetcode.com/problems/triangle/
public static class Solution
{
    /*
         * Alg
         *      2
         *      3 4
         *     6 5 7
         *    4 1 8 3
         *
         *   for each row, sort the items
         *   take the sum first of each row
         *   return the minimum path sum from top to bottom
         *   this is slow
         *   
         *   the challenge is to make this run in O(n)
         *   which would happen if we do a sort that runs in O(n) in parallel
         *   then take 
        */
    public static int MinimumTotalSlow(IList<IList<int>> triangle)
    {
        var sortedTriangle = new List<int[]>();
        foreach (var row in triangle)
        {
            var rowArr = row.ToArray();
            Array.Sort(rowArr);
            sortedTriangle.Add(rowArr);
        }

        var sum = 0;
        foreach (var row in sortedTriangle)
        {
            sum += row[0];
        }

        return sum;
    }

    public static int MinimumTotal(IList<IList<int>> triangle)
    {
        if (triangle == null || triangle.Count() == 0)
        {
            return 0;
        }

        var minSumList = triangle[triangle.Count() - 1];
        int listIndex = triangle.Count() - 2;
        while (listIndex >= 0)
        {
            for (int i = 0; i < triangle[listIndex].Count(); i++)
            {
                minSumList[i] = triangle[listIndex][i] + GetMin(minSumList[i], minSumList[i + 1]);
            }

            listIndex--;
        }

        return minSumList[0];
    }

    private static int GetMin(int a, int b)
    {
        return a < b ? a : b;
    }
}
