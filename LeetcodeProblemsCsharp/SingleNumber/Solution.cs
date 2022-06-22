public static class Solution
{
    // Needs to be O(n)
    /*
    Alg
        Option 1
        keep a list of the visited nums
        if a nums appears in the list, as we're iterating, remove it
        the resulting list would be only 1
        return that one
        
        Option 2
        but is this O(n)?
            if sorting takes O(n) then you still need to iterate through the array to find which one doesn't appear
            worst case is O(n)
            so this becomes O(2n)
        sort the array
    */
    public static int SingleNumber(int[] nums)
    {
        return SingleNumberImproved(nums);
    }

    private static int SingleNumber1(int[] nums)
    {
        if (nums == null) return 0;

        var visitedNums = new List<int>();

        for (var i = 0; i < nums.Length; i++)
        {
            var num = nums[i];

            if (visitedNums.Contains(num)) visitedNums.Remove(num);
            else visitedNums.Add(num);
        }

        return visitedNums.First();
    }

    private static int SingleNumberImproved(int[] nums)
    {
        if (nums == null) return 0;
        if (nums.Length == 1) return nums[0];

        Array.Sort(nums);

        for (var i = 1; i < nums.Length; i += 2)
        {
            if (nums[i] != nums[i - 1]) return nums[i - 1];
        }

        return nums[nums.Length - 1];
    }
}