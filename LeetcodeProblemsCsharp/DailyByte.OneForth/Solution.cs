/*
 * Given an array of integers, nums, sorted in ascending order, return the element that occurs more than one fourth of the time.
 * Note: If no element appears more than a fourth of the time, return -1.
 * 
 * Ex: Given the following nums…
 * nums = [1, 2, 2, 3, 4], return 2.
 * 
 * Ex: Given the following nums…
 * nums = [1, 2, 3, 4], return -1.
 */

public static class Solution
{
    public static int OneFourthV1(int[] nums)
    {
        if (!nums.Any()) return 0;

        var numsSize = nums.Length;
        var numbers = new Dictionary<int, int>();

        for (var i = 0; i < nums.Length; i++)
        {
            if (numbers.ContainsKey(nums[i])) numbers[nums[i]]++;
            else numbers.Add(nums[i], 1);
        }

        var numsSizeOneFourth = numsSize / 4;
        var oneFourthNumber = -1;

        foreach (var num in numbers)
        {
            if (num.Value > numsSizeOneFourth)
            {
                oneFourthNumber = num.Key;
                break;
            }
        }

        return oneFourthNumber;
    }

    public static int OneFourthV2(int[] nums)
    {
        if (!nums.Any()) return 0;

        var numsSize = nums.Length;
        var numsSizeOneFourth = numsSize / 4;
        var oneFourthNumber = -1;
        var numbers = new Dictionary<int, int>();

        for (var i = 0; i < nums.Length; i++)
        {
            if (numbers.ContainsKey(nums[i])) numbers[nums[i]]++;
            else numbers.Add(nums[i], 1);

            if (numbers[nums[i]] > numsSizeOneFourth)
            {
                oneFourthNumber = nums[i];
                break;
            }
        }


        return oneFourthNumber;
    }

    private static List<int[]> DataSet()
    {
        return new List<int[]>
        {
            new int[] { 1, 2, 2, 3, 4 },
            new int[] { 1, 2, 3, 4 },
            new int[] { 1, 2, 3, 4, 5, 6, 7 },
            new int[] { 1, 1, 1, 1 }
        };
    }

    public static void ExamplesV1()
    {
        var exs = DataSet();

        foreach (var ex in exs)
        {
            Console.WriteLine($"[{string.Join(',', ex)}] => {OneFourthV1(ex)}");
        }
    }

    public static void ExamplesV2()
    {
        var exs = DataSet();

        foreach (var ex in exs)
        {
            Console.WriteLine($"[{string.Join(',', ex)}] => {OneFourthV2(ex)}");
        }
    }
}