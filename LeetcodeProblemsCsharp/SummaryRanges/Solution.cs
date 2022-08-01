// https://leetcode.com/problems/summary-ranges/
public static class Solution
{
    public static IList<string> SummaryRanges(int[] nums)
    {
        var res = new List<string>();

        if (nums == null || nums.Length == 0) return res;

        int i = 0;

        for (int j = 0; j < nums.Length - 1; j++)
        {
            if (nums[j] + 1 != nums[j + 1])
            {
                res.Add(nums[i] == nums[j] 
                    ? nums[i].ToString() 
                    : nums[i].ToString() + "->" + nums[j].ToString());

                i = j + 1;
            }
        }

        res.Add(i == nums.Length - 1 
            ? nums[i].ToString() 
            : nums[i].ToString() + "->" + nums[nums.Length - 1].ToString());

        return res;
    }
}