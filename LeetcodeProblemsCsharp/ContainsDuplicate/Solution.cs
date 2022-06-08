// https://leetcode.com/problems/contains-duplicate/
public static class Solution
{
    /*
     * Alg
     *      create a hashset with the numbs array
     *      if the counts don't match then it contains duplicates
     *      hashset only contains unique values
     */
    public static bool ContainsDuplicate(int[] nums)
    {
        return nums.ToHashSet().Count() != nums.Count();
    }
}
