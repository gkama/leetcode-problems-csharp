// https://leetcode.com/problems/merge-sorted-array/
public static class Solution
{
    public static void Merge(int[] nums1, int m, int[] nums2, int n)
    {
        if (n == 0)
        {
            return;
        }

        for (var i = m; i < m + n; i++)
        {
            nums1[i] = nums2[i - m];
        }

        if (m == 0)
        {
            return;
        }

        var len = m + n;
        for (var i = 0; i < len; i++)
        {
            for (var j = i + 1; j < len; j++)
            {
                if (nums1[i] > nums1[j])
                {
                    var temp = nums1[i];
                    nums1[i] = nums1[j];
                    nums1[j] = temp;
                }
            }
        }

        return;
    }
}
