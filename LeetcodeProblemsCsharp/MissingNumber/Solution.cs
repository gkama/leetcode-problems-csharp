// https://leetcode.com/problems/missing-number/
public static class Solution
{
    public static int MissingNumberV2(int[] nums)
    {
        Array.Sort(nums);

        for (var i = 0; i < nums.Length; i++)
        {
            if (nums[i] != i) return i;
        }

        return nums.Length;
    }

    public static int MissingNumberV1(int[] nums)
    {
        var n = nums.Length;

        Array.Sort(nums);

        if (n == 1 && nums[0] != 0) return 0;
        if (nums[0] != 0) return 0;

        for (var i = 1; i < n; i++)
        {
            // Current must be greater than revious by one
            // If not, then it doesn't exist
            var curr = nums[i];
            var prev = nums[i - 1];

            if (curr - prev > 1) return curr - 1;
        }

        return nums[n - 1] + 1;
    }
}
