/*
 * Given an array of integers, nums, every value appears three times except one value which only appears once. Return the value that only appears once.
 * 
 * Ex: Given the following array nums…
 * nums = [1, 2, 2, 2, 3, 3, 3], return 1.
 * 
 * Ex: Given the following array nums…
 * nums = [3, 3, 2, 5, 2, 2, 5, 3, 9, 5], return 9.
 */

public static class Solution
{
    public static int OneValue(int[] nums)
    {
        var allValues = new Dictionary<int, int>();

        for (var i = 0; i < nums.Length; i++)
        {
            var key = nums[i];

            if (allValues.ContainsKey(key))
            {
                allValues[key] += 1;
            }
            else
            {
                allValues.Add(key, 1);
            }
        }

        return allValues.OrderBy(x => x.Value)
            .First()
            .Key;
    }

    public static void Examples()
    {
        var exs = new List<int[]>()
        {
            new int[] { 1, 2, 2, 2, 3, 3, 3 },
            new int[] { 3, 3, 2, 5, 2, 2, 5, 3, 9, 5 }
        };

        foreach (var ex in exs)
        {
            Console.WriteLine($"{string.Join(',', ex)} -> {OneValue(ex)}");
        }
    }
}