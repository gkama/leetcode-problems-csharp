// https://leetcode.com/problems/intersection-of-two-arrays-ii/
public static class Solution
{
    public static int[] Intersect(int[] nums1, int[] nums2)
    {
        var intersection = new List<int>();

        var index1 = 0;
        var index2 = 0;

        while (index1 < nums1.Length)
        {
            while (index2 < nums2.Length && index1 < nums1.Length)
            {
                if (nums1[index1] == nums2[index2])
                {
                    intersection.Add(nums2[index2]);
                    index1 = index1 + 1;
                }

                index2 = index2 + 1;
            }

            index2 = 0; // Reset
            index1 = index1 + 1;
        }

        return intersection.ToArray();
    }

    public static int[] IntersectV2(int[] nums1, int[] nums2)
    {
        var count = new Dictionary<int, int>();

        foreach (var n in nums1)
        {
            if (!count.ContainsKey(n))
            {
                count.Add(n, 0);
            }

            count[n]++;
        }

        var intersection = new List<int>();

        foreach (var n in nums2)
        {
            if (count.ContainsKey(n) && count[n] > 0)
            {
                intersection.Add(n);
                count[n]--;
            }
        }

        return intersection.ToArray();
    }
}
