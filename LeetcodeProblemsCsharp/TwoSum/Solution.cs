public static class Solution
{
    public static int[] TwoSum(int[] nums, int target)
    {
        return BigONSquared(nums, target);
    }

    // O(n^2)
    private static int[] BigONSquared(int[] nums, int target)
    {
        var indices = new List<int>();

        for (int i = 0; i < nums.Length; i++)
        {
            for (int j = i + 1; j < nums.Length; j++)
            {
                if (nums[i] + nums[j] == target)
                {
                    indices.AddRange(new int[] { i, j });

                    goto found;
                }
            }
        }

        found: return indices.ToArray();
    }
}