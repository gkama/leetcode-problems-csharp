/*
 * This question is asked by Amazon. Given two arrays of numbers, where the first array is a subset of the second array, 
 * return an array containing all the next greater elements for each element in the first array, in the second array.
 * If there is no greater element for any element, output -1 for that number.
 * 
 * Ex: Given the following arrays…
 * nums1 = [4,1,2], nums2 = [1,3,4,2], return [-1, 3, -1] because no element in nums2 is greater than 4, 3 is the first number in nums2 greater than 1, and no element in nums2 is greater than 2.
 * nums1 = [2,4], nums2 = [1,2,3,4], return [3, -1] because 3 is the first greater element that occurs in nums2 after 2 and no element is greater than 4.
 * 
 * [1,2,4] [1,2,3,4,]
 */
public static class Solution
{
    public static int[] GreaterElements(int[] nums1, int[] nums2)
    {
        return GreaterElementsV1(nums1, nums2);
    }

    // O(n * m)
    public static int[] GreaterElementsV1(int[] nums1, int[] nums2)
    {
        var result = new int[nums1.Length];

        // a1 is a subset of a2
        for (var i = 0; i < nums1.Length; i++)
        {
            var value = nums1[i];

            for (var j = 0; j < nums2.Length; j++)
            {
                if (nums2[j] > value 
                    && !nums1.Contains(nums2[j]) 
                    && !result.Contains(nums2[j]))
                {
                    result[i] = nums2[j];
                    break;
                }
            }

            if (result[i] == 0) result[i] = -1;
        }

        return result;
    }

    // Try
    public static int[] GreaterElementsV2(int[] nums1, int[] nums2)
    {
        var result = new int[nums1.Length];
        var a1Index = 0;

        // Assume: first greater nums2 not in nums1


        return result;
    }

    public static void Examples()
    {
        var exs = new Dictionary<int[], int[]>
        {
            { new [] { 4, 1, 2 }, new [] { 1, 3, 4, 2 } },
            { new [] { 2, 4 }, new [] { 1, 2, 3, 4 } }
        };

        foreach (var ex in exs)
        {
            var res = GreaterElements(ex.Key, ex.Value);

            Console.WriteLine($"[{string.Join(",", ex.Key)}] and [{string.Join(",", ex.Value)}] -> [{string.Join(",", res)}]");
        }
    }
}
