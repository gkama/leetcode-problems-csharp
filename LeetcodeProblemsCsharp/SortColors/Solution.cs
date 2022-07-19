// https://leetcode.com/problems/sort-colors/
public static class Solution
{
    /*
    red, white blue sorted
    0, 1 and 2
    0 is pushed all the way to the beginning
    2 is pushed all the way to the end
    1 is pushed in the middle
    */
    public static void SortColors(int[] nums)
    {
        if (nums == null) return;

        for (var i = 0; i < nums.Length; i++)
        {
            for (var j = i + 1; j < nums.Length; j++)
            {
                var temp = nums[i];

                if (nums[j] < temp) //Swap
                {
                    nums[i] = nums[j];
                    nums[j] = temp;
                }
            }
        }
    }
}