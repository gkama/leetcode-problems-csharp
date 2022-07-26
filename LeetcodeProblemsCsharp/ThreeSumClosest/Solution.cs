// https://leetcode.com/problems/3sum-closest/
public static class Solution
{
    public static int ThreeSumClosest(int[] nums, int target)
    {
        var closest = int.MaxValue;

        Array.Sort(nums);

        for (var i = 0; i < nums.Length - 2; i++)
        {
            var j = i + 1;
            var k = nums.Length - 1;

            while (j < k)
            {
                var value = nums[i] + nums[j] + nums[k];

                if (value == target) return value;

                var current = Math.Abs(target - closest);
                var compare = Math.Abs(target - value);

                if (current > compare)
                {
                    closest = value;
                }

                if (value > target) k--;
                else j++;
            }
        }

        return closest;
    }

    // O(n^3)
    public static int ThreeSumClosestV2(int[] nums, int target)
    {
        var closest = int.MaxValue;

        for (var i = 0; i < nums.Length; i++)
        {
            for (var j = i + 1; j < nums.Length; j++)
            {
                for (var k = j + 1; k < nums.Length; k++)
                {
                    var value = nums[i] + nums[j] + nums[k];

                    if (value == target) return value;

                    if (Math.Abs(target - closest) > Math.Abs(target - value))
                    {
                        closest = value;
                    }
                }
            }
        }

        return closest;
    }
}