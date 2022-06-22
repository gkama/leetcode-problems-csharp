public static class Solution
{
    /*
    Alg
        keep a dictionary of what nums appeared and how many times
        check each time, as soon as that element is at n/2 times return
    */
    public static int MajorityElement(int[] nums)
    {
        if (nums == null) return 0;

        var size = nums.Length;
        var majoritySize = size / 2;
        var visitedNums = new Dictionary<int, int>();

        for (var i = 0; i < size; i++)
        {
            var value = nums[i];

            if (!visitedNums.ContainsKey(value))
            {
                visitedNums.Add(value, 1);
            }
            else
            {
                visitedNums[value] += 1;
            }

            if (visitedNums[value] > majoritySize)
            {
                return value;
            }
        }

        return 0;
    }
}