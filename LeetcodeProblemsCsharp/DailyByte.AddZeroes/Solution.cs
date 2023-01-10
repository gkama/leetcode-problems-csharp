/*
 * Given an array of integers, nums, duplicate the occurrence of each zero in the array by shifting other non-zero elements to the right.
 * Note: The modification to nums must be done in-place, do not return anything from your function, and elements beyond the length of the original array not not written.
 * 
 * Ex: Given the following nums...
 * nums = [1, 0, 4, 0, 5, 8], return null but nums should look as follows after your function runs [1,0,0,4,0,0].
 * 
 * Ex: Given the following nums...
 * nums = [1, 4, 9], return null but nums should look as follows after your function runs [1, 4, 9].
 */

public static class Solution
{
    public static int[] AddZeroes(int[] nums)
    {
        if (!nums.ToList().Contains(0)) return nums; // Could potentially remove to eliminate extra complexity

        for (var i = 0; i < nums.Length - 1; i++)
        {
            if (nums[i] != 0) continue;

            // Shift array to the right by adding a 0 and using a queue
            // Works with queues, but it's slow
            var queue = new Queue<int>();
            queue.Enqueue(0);
            for (var j = i + 1; j < nums.Length - 1; j++)
            {
                queue.Enqueue(nums[j]);
            }

            // Populate array
            for (var k = i + 1; k < nums.Length; k++)
            {
                var next = queue.Dequeue();
                nums[k] = next;
            }

            i++;
        }

        return nums;
    }

    public static void Examples()
    {
        var exs = new List<int[]>
        {
            new int[] { 1, 0, 4, 0, 5, 8 },
            new int[] { 1, 4, 9 }
        };

        foreach (var ex in exs)
        {
            Console.WriteLine($"[{string.Join(',', ex)}] -> [{string.Join(',', AddZeroes(ex))}]");
        }
    }
}