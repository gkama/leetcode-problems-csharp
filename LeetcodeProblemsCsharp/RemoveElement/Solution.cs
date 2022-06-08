// https://leetcode.com/problems/remove-element/
public class Solution
{
    public static int RemoveElement(int[] nums, int val)
    {
        /*
         * Input: nums = [3,2,2,3], val = 3
         * Output: 2, nums = [2,2,_,_]
         * 
         * remove an element without creating a new array
         * modify the existing array in-place
         * 
         * Alg
         *      do a modified selection sort but in reverse
         *      if we see a nums[i] that is equal to val then swap it backwards until the end
         *      if we work from 0 to length, then we'll skip vals next to each other [0,2,2,3]
         */

        if (nums == null) return 0;
        else if (nums.Length == 1 && nums[0] != val) return 1;
        else if (nums.Length == 1 && nums[0] == val)
        {
            nums[0] = default(int);
            return 0;
        };

        for (var i = nums.Length - 1; i >= 0; i--)
        {
            if (nums[i] == val && i == nums.Length - 1) continue;
            
            if (nums[i] == val)
            {
                for (var j = i; j < nums.Length - 1; j++)
                {
                    // Swap
                    var temp = nums[j];
                    nums[j] = nums[j + 1];
                    nums[j + 1] = temp;
                }
            }
        }

        var n = 0;
        for (var k = 0; k < nums.Length; k++)
        {
            if (nums[k] != val) n++;
            else break;
        }

        return n;
    }
}
