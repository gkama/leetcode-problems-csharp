// https://leetcode.com/problems/remove-duplicates-from-sorted-array/
public static class Solution
{
    public static int RemoveDuplicates(int[] nums)
    {
        /*
         * non-decreasing order (increasting order)
         * remove duplciates in-place such that each unique element appears only once
         * relative order should be kept the same
         * put the sorted list in the first k elements (doesn't matter what's after)
         * do not create a new array, modify existing one
         * 
         * Alg
         *  since it's already sorted
         *  keep 2 indices
         *  first one is at the beginning and then it'll be incremented when we find a match that isn't equal
         *  second one searches for the next bigger value
         *  
         *  ++i returns the incremented value
         *  i++ increments it and returns the previous value
         *  
         *  * index1
         *  - index2
         *  
         *  0*, 0-, 1, 1, 1, 1, 2, 2, 3, 3, 4   equal
         *  0*, 0, 1-, 1, 1, 1, 2, 2, 3, 3, 4   not eqaul
         *  0*, 0, 1-, 1, 1, 1, 2, 2, 3, 3, 4   put value at index2 at index1 + 1
         *  0, 1*, 1, 1-, 1, 1, 2, 2, 3, 3, 4   equal
         *  0, 1*, 1, 1, 1-, 1, 2, 2, 3, 3, 4   equal
         *  0, 1*, 1, 1, 1, 1-, 2, 2, 3, 3, 4   equal
         *  0, 1*, 1, 1, 1, 1, 2-, 2, 3, 3, 4   not eqaul
         *  0, 1, 2*, 1, 1, 1, 2, 2-, 3, 3, 4   equal
         *  0, 1, 2*, 1, 1, 1, 2, 2, 3-, 3, 4   not equal
         *  0, 1, 2, 3*, 1, 1, 2, 2, 3, 3-, 4   equal
         *  0, 1, 2, 3, 4*, 1, 2, 2, 3, 3, 4-   not equal
         *  end
         *  
         */

        if (nums.Count() <= 1) return nums.Count();

        var index1 = 0;
        var index2 = 1;

        while (index2 <= nums.Length - 1)
            if (nums[index1] == nums[index2])
                index2++;
            else
                nums[++index1] = nums[index2++];

        return ++index1;
    }
}