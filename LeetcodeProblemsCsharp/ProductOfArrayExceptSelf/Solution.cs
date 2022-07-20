// https://leetcode.com/problems/product-of-array-except-self/
public static class Solution
{
    public static int[] ProductExceptSelf(int[] nums)
    {
        return ProductExceptSelfV2(nums);
    }

    public static int[] ProductExceptSelfV2(int[] nums)
    {
        if (nums == null) return null;

        var result = new int[nums.Length];
        var totalProduct = 1;
        var totalProductWithoutZeroes = 1;
        var totalNumOfZeroes = 0;

        // Calculate total prodct
        // O(n)
        for (var i = 0; i < nums.Length; i++)
        {
            totalProduct *= nums[i];

            if (nums[i] == totalNumOfZeroes)
            {
                totalNumOfZeroes++;
            }
            else
            {
                totalProductWithoutZeroes *= nums[i];
            }
        }

        // O(n)
        for (var i = 0; i < nums.Length; i++)
        {
            if (nums[i] == 0 && totalNumOfZeroes == 1)
            {
                result[i] = totalProductWithoutZeroes;
            }
            else
            {
                result[i] = totalProduct / nums[i];
            }
        }

        return result;
    }

    public static int[] ProductExceptSelfV1(int[] nums)
    {
        if (nums == null) return null;

        var result = new int[nums.Length];

        for (var i = 0; i < nums.Length; i++)
        {
            var product = 1;

            for (var j = 0; j < nums.Length; j++)
            {
                product *= i != j ? nums[j] : 1;
            }

            result[i] = product;
        }

        return result;
    }
}