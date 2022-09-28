/*
 * This question is asked by Amazon. Given an array of integers, nums, sort the array in any manner such that when i is even, nums[i] is even and when i is odd, nums[i] is odd.
 * Note: It is guaranteed that a valid sorting of nums exists.
 * 
 * Ex: Given the following array nums…
 * nums = [1, 2, 3, 4], one possible way to sort the array is [2,1,4,3]
 */

public class Solution
{
    public static int[] ArrayShuffleV1(int[] nums)
    {
        if (nums.Length < 2) return nums;

        // Iterate through the array, if we see that i is not even / odd
        // then swap following elements until we see one
        for (var i = 0; i < nums.Length; i++)
        {
            var iIsEven = i % 2 == 0;
            var numsIIsEven = nums[i] % 2 == 0;

            if (iIsEven && numsIIsEven) continue;
            if (!iIsEven && !numsIIsEven) continue;

            // Swap until we find an even one
            for (var j = i + 1; j < nums.Length; j++)
            {
                var numsJIsEven = nums[j] % 2 == 0;

                // Swap
                if (iIsEven && numsJIsEven
                    || !iIsEven && !numsJIsEven)
                {
                    var temp = nums[i];

                    nums[i] = nums[j];
                    nums[j] = temp;

                    break;
                }
            }
        }

        return nums;
    }

    public static void Examples()
    {
        var exs = new List<int[]>
        {
            new int[] { 1, 2, 3, 4 },
            new int[] { 2, 1, 4, 3 },
            new int[] { 1, 2, 3, 4, 5, 6, 7, 8 },
            new int[] { 1, 3, 5, 2, 4, 6 },
            new int[] { 2, 4, 6, 1, 3, 5 }
        };

        foreach (var ex in exs)
        {
            Console.WriteLine($"{string.Join(", ", ex)} -> {string.Join(", ", ArrayShuffleV1(ex))}");
        }
    }
}
