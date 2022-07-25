// https://leetcode.com/problems/contains-duplicate-ii/
public class Solution
{
    public bool ContainsNearbyDuplicate(int[] nums, int k)
    {
        return ContainsNearbyDuplicateV2(nums, k);
    }


    private bool ContainsNearbyDuplicateV2(int[] nums, int k)
    {
        if (nums.Length < 1) return false;

        var dict = new Dictionary<int, List<int>>();

        for (var i = 0; i < nums.Length; i++)
        {
            if (dict.ContainsKey(nums[i]))
            {
                foreach (var index in dict[nums[i]])
                {
                    if (Math.Abs(i - index) <= k) return true;
                }

                dict[nums[i]].Add(i);
            }
            else
            {
                dict.Add(nums[i], new List<int> { i });
            }
        }

        return false;
    }


    private bool ContainsNearbyDuplicateV1(int[] nums, int k)
    {
        if (nums.Length < 1) return false;

        var dict = new Dictionary<int, int>();

        for (var i = 0; i < nums.Length; i++)
        {
            if (dict.ContainsKey(nums[i]))
            {
                if (Math.Abs(i - dict[nums[i]]) <= k)
                {
                    return true;
                }
                else
                {
                    continue;
                }
            }

            dict.Add(i, nums[i]);
        }

        return false;
    }
}