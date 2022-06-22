public class Solution
{
    // Faster
    // Source: https://www.code-recipe.com/post/three-sum
    public static IList<IList<int>> ThreeSum(int[] nums)
    {
        var triplets = new List<IList<int>>();

        if (nums == null) return triplets;
        if (nums.Length < 3) return triplets;

        // Sort the array
        Array.Sort(nums);

        var length = nums.Length;

        for (var i = 0; i < length - 2; i++)
        {
            if (i > 0 && nums[i] == nums[i - 1])
            {
                continue;
            }

            var j = i + 1;
            var k = length - 1;

            while (k > j)
            {
                var sum = nums[j] + nums[k] + nums[i];

                if (sum == 0)
                {
                    triplets.Add(new List<int> { nums[j], nums[k], nums[i] });

                    k--;

                    while (j < k && nums[k] == nums[k + 1]) k--;
                }
                else if (sum > 0)
                {
                    k--;
                }
                else
                {
                    j++;
                }
            }
        }

        return triplets;
    }

    /*
    Alg
        run 3 loops
        one at i = 0 , j = i + 1, k = i + 2
        don't even bother with elements with less size
        (Optimize) to make this faster, keep a history of additions that we've done
    */
    public IList<IList<int>> ThreeSumSlow(int[] nums)
    {
        var triplets = new HashSet<IList<int>>();

        if (nums == null) return triplets.ToList();
        if (nums.Length < 3) return triplets.ToList();

        var length = nums.Length;

        for (var i = 0; i < length - 2; i++)
        {
            for (var j = i + 1; j < length - 1; j++)
            {
                for (var k = j + 1; k < length; k++)
                {
                    if (i != j && i != k && j != k
                        && (nums[i] + nums[j] + nums[k] == 0))
                    {
                        // What is a duplicate triplet
                        // If there exists a list that has the same combination of numbers nums[i] nums[j] or nums[k]
                        var setOfTriplets = new int[3]
                        {
                            nums[i],
                            nums[j],
                            nums[k]
                        };
                        Array.Sort(setOfTriplets);

                        var setOfTripletsExists = false;
                        foreach (var triplet in triplets)
                        {
                            var tripletArray = triplet.ToArray();
                            Array.Sort(tripletArray);

                            if (setOfTriplets[0] == tripletArray[0]
                               && setOfTriplets[1] == tripletArray[1]
                               && setOfTriplets[2] == tripletArray[2])
                            {
                                // Exists
                                setOfTripletsExists = true;
                                goto checkToAdd;
                            }
                        }

                    checkToAdd: if (!setOfTripletsExists)
                        {
                            triplets.Add(setOfTriplets);
                        }
                    }
                }
            }
        }

        return triplets.ToList();
    }
}