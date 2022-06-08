// https://leetcode.com/problems/maximum-subarray/
public static class Solution
{
    /*
     * Alg
     *      keep a running sum
     *      keep a max sum, starting at the first number
     *      compare the two
     */
    public static int MaxSubArray(int[] nums)
    {
        if (nums.Length == 1) return nums[0];

        int sum = 0,
            maxSum = nums[0];

        for (var i = 0; i < nums.Length; i++)
        {
            sum += nums[i];

            if (nums[i] > sum)
            {
                sum = nums[i];
            }

            if (sum > maxSum)
            {
                maxSum = sum;
            }
        }

        return maxSum;
    }
}




