// https://leetcode.com/problems/binary-search/
public static class Solution
{
    public static int Search(int[] nums, int target)
    {
        if (nums == null || nums.Length == 0) return -1;

        var currentIterations = 0;
        var maxIterations = nums.Length / 2 + 1;

        int InternalSearch(int[] nums, int min, int max, int target)
        {
            if (currentIterations == maxIterations) return -1;

            var mid = (min + max) / 2;

            if (nums[mid] == target) return mid;
            else if (nums[mid] > target)
            {
                currentIterations++;
                return InternalSearch(nums, min, mid - 1, target);
            }
            else
            {
                currentIterations++;
                return InternalSearch(nums, mid + 1, max, target);
            }
        }

        return InternalSearch(nums, 0, nums.Length - 1, target);
    }
}