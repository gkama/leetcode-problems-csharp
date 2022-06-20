// https://leetcode.com/problems/rotate-array/
public static class Solution
{
    /*
    Alg
        iterate 0 to k
        selection sort swapping until the end
    */
    public static void Rotate(int[] nums, int k)
    {
        if (nums == null || k == 0 || nums.Length == 1)
        {
            return;
        }

        var arr = WithNewArray(nums, k);

        for (var i = 0; i < nums.Length; i++)
        {
            nums[i] = arr[i];
        }
    }

    /*
    Alg
        since it doesn't say to not use another array
        we'll create a new array
        1. start at nums.length - k and iterate to the end
            add those elements first to the array
        2. iterate 0 to nums.length - k 
            add those elements
    */
    private static int[] WithNewArray(int[] nums, int k)
    {
        if (nums == null || k == 0)
        {
            return null;
        }

        var numsLength = nums.Length;
        var rotatedArray = new int[numsLength];
        var numsLengthMinusK = numsLength - k;

        for (var i = 0; i < numsLength; i++)
        {
            if (i < numsLengthMinusK)
            {
                rotatedArray[i + k] = nums[i];
            }
            else
            {
                rotatedArray[(i + k) % numsLength] = nums[i];
            }
        }

        return rotatedArray;
    }
}