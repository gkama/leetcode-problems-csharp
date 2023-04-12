/*
 * Given an array of positive integers, nums, return the largest sum we can create such that it is divisible by three.
 * 
 * Ex: Given the following nums…
 * nums = [3, 1, 5, 8, 2], return 18 (3 + 5 + 8 + 2).
 * 
 * Ex: Given the following nums…
 * nums = [2, 4, 9], return 15.
 */

public static class Solution
{
    public static int LargestSumDivisibleByThreeV1(int[] nums)
    {
        var sum = 0;
        var biggestSum = 0;

        for (var i = 0; i < nums.Length; i++)
        {
            sum += nums[i];

            if (biggestSum < sum && IsDivisibleByThree(sum))
            {
                biggestSum = sum;
            }
        }

        return biggestSum;
    }

    public static int LargestSumDivisibleByThreeV2(int[] nums)
    {
        var biggestSum = 0;

        for (var i = 0; i < nums.Length; i++)
        {
            var sum = nums[i];

            if (biggestSum < sum && IsDivisibleByThree(sum)) biggestSum = sum;

            for (var j = i + 1; j < nums.Length; j++)
            {
                sum = nums[i];

                for (var k = j; k < nums.Length; k++)
                {
                    sum += nums[k];

                    if (biggestSum < sum && IsDivisibleByThree(sum)) biggestSum = sum;
                }
            }
            
        }

        return biggestSum;
    }

    private static bool IsDivisibleByThree(int num)
    {
        if (num < 100000) return num % 3 == 0;

        var sumOfDigits = 0;
        foreach (var digitChar in num.ToString())
        {
            var digit = Convert.ToInt32(digitChar);
            sumOfDigits += digit;
        }

        return sumOfDigits % 3 == 0;
    }

    public static void Examples()
    {
        var exs = new List<int[]>
        {
            new int[] { 3, 1, 5, 8, 2 },
            new int[] { 2, 4, 9 },
            new int[] { 3, 3, 3, 3, 3, 3, 3, 3, 3, 3 }
        };

        foreach (var ex in exs)
        {
            Console.WriteLine($"[{string.Join(',', ex)}] => {LargestSumDivisibleByThreeV2(ex)}");
        }
    }
}