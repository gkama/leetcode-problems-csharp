/*
 * This question is asked by Facebook. Given an array nums, return whether or not its values are monotonically increasing or monotonically decreasing.
 * Note: An array is monotonically increasing if for all values i <= j, nums[i] <= nums[j]. Similarly an array is monotonically decreasing if for all values i <= j, nums[i] >= nums[j].
 * 
 * Ex: Given the following array nums…
 * nums = [1, 2, 3, 4, 4, 5], return true.
 * 
 * Ex: Given the following array nums…
 * nums = [7, 6, 3], return true.
 * 
 * Ex: Given the following array nums…
 * nums = [8, 4, 6], return false.
 */
public class Solution
{
    public static bool IsMonotonic(int[] nums)
    {
        if (nums.Length == 0) return true;

        var isIncreasing = false;
        var isDecreasing = false;

        for (var i = 1; i < nums.Length; i++)
        {
            if (nums[i] > nums[i - 1]) isIncreasing = true;
            if (nums[i] < nums[i - 1]) isDecreasing = true;

            if (isIncreasing && isDecreasing) return false;
        }

        return true;
    }

    public static void Examples()
    {
        var exs = new List<int[]>
        {
            new int[] { 1, 2, 3, 4, 4, 5 },
            new int[] { 7, 6, 3 },
            new int[] { 8, 4, 6 },
            new int[] { 1, 3, 0, -2, 5 }
        };

        foreach (var ex in exs)
        {
            Console.WriteLine($"{string.Join(", ", ex)} -> {IsMonotonic(ex)}");
        }
    }
}
