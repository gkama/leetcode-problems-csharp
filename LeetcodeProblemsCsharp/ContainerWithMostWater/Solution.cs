// https://leetcode.com/problems/container-with-most-water/
using static System.Formats.Asn1.AsnWriter;
using System.Reflection;
using System.Runtime.InteropServices;

public static class Solution
{
    // O(n)
    /*
     * Here we’ll solve using the 2pointer approach.
     * We took 2 pointers start & end.
     * Calculate the area with the minimum height multiplied by distance.
     * Store the maximum to ans.
     * Move the shorter height among 2 pointers to the next position.
     * Time complexity: O(n).
    */
    public static int MaxArea(int[] height)
    {
        if (height.Length == 0) return 0;

        var biggest = 0;
        var start = 0;
        var end = height.Length - 1;

        while (start < end)
        {
            var area = Math.Min(height[start], height[end]) * (end - start);
            biggest = Math.Max(biggest, area);

            if (height[start] > height[end])
                end--;
            else
                start++;
        }

        return biggest;
    }

    // Too slow (time limit exceeded)
    // O(n^2)
    public static int MaxAreaV2(int[] height)
    {
        // Need to calculate the differences in i
        // And the height, the closes together
        // i to i is the x-axis
        // height to height is the y-axis
        // i to i times height to height is the area

        if (height.Length == 0) return 0;

        var biggest = 0;

        for (var i = 0; i < height.Length; i++)
        {
            var widthStart = i;

            for (var j = i + 1; j < height.Length; j++)
            {
                var width = j - widthStart;
                var heightI = height[i];
                var heightJ = height[j];
                var area = 0;

                if (heightI > heightJ)
                {
                    area = heightJ * width;
                }
                else if (heightJ > heightI)
                {
                    area = heightI * width;
                }
                else
                {
                    area = heightI * width;
                }

                if (area > biggest)
                {
                    biggest = area;
                }
            }
        }

        return biggest;
    }
}
