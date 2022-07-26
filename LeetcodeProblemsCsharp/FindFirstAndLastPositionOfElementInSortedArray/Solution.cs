// https://leetcode.com/problems/find-first-and-last-position-of-element-in-sorted-array/
public static class Solution
{
    public static int[] SearchRange(int[] nums, int target)
    {
        var res = new int[] { -1, -1 };

        if (nums.Length < 1) return res;
        if (nums.Length == 2)
        {
            if (nums[0] == target && nums[1] == target) { res[0] = 0; res[1] = 1; }
            else if (nums[0] == target) { res[0] = 0; res[1] = 0; }
            else if (nums[1] == target) { res[0] = 1; res[1] = 1; }

            return res;
        }

        var min = 0;
        var max = nums.Length - 1;
        var index = -1;
        var valueFound = int.MinValue;

        while (min <= max)
        {
            var mid = (min + max) / 2;

            if (target == nums[mid])
            {
                index = mid;
                valueFound = nums[index];
                break;
            }

            if (target > nums[mid])
            {
                min = mid + 1;
            }
            else
            {
                max = mid - 1;
            }
        }

        res[0] = index;

        Console.WriteLine(index);

        if (index == -1)
        {
            res[1] = -1;
        }
        else if (index != 0 && nums[index - 1] == valueFound)
        {
            res[0] = index - 1;
            res[1] = index;
        }
        else if (index != nums.Length - 1 && nums[index + 1] == valueFound)
        {
            res[0] = index;
            res[1] = index + 1;
        }
        else
        {
            res[1] = index;
        }

        return res;
    }
}