public static class Solution
{
    public static bool HasTwoSum(int[] nums, int target)
    {
        if (nums == null || nums.Length < 2) return false;

        var dictionary = new Dictionary<int, int>();

        for (var i = 0; i < nums.Length; i++)
        {
            if (dictionary.ContainsKey(target - nums[i]))
            {
                return true;
            }
            else if (!dictionary.ContainsKey(nums[i]))
            {
                dictionary.Add(nums[i], i);
            }
        }

        return false;
    }

    public static void Examples()
    {
        var exs = new Dictionary<int, int[]>
        {
            { 10, new int[] { 1, 3, 8, 2 } },
            { 8, new int[] { 3, 9, 13, 7 } },
            { 4, new int[] { 4, 2, 6, 5, 2 } },
            { 1, new int[] { -3, 4, 6, 5, 2 } },
            { -4, new int[] { -3, 4, 6, 5, -1 } },
        };

        foreach (var ex in exs)
        {
            Console.WriteLine($"{ex.Key} in {string.Join(",", ex.Value)} -> {HasTwoSum(ex.Value, ex.Key)}");
        }
    }
}
