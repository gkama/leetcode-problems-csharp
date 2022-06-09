// https://leetcode.com/problems/search-insert-position/
public class Solution
{
    /*
     * Alg
     *      sort of a greedy alg
     *      divide the array 4 times (binary search)
     *      this will work great for 
     *      do a binary search and show where it should be inserted
     *      this will be O(log n)
     */
    public static int SearchInsert(int[] nums, int target)
    {
        if (nums == null || nums.Length == 0)
        {
            return -1;
        }

        int i = 0,
            j = nums.Length - 1;

        while (i <= j)
        {
            int m = j + (i - j) / 2;

            if (nums[m] == target)
            {
                return m;
            }
            else if (nums[m] < target)
            {
                i = m + 1;
            }
            else
            {
                j = m - 1;
            }
        }

        return i;
    }
}
