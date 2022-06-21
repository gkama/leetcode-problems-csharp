public static class Solution
{
    /*
    Alg
        sorted in ascending order
        index 2 must be greater than index 1
        return as an integer array [index1, idnex2]
        cannot use same element twice
        must use only constant extra space
        
        solution
            iterate through the array backwards
            start at end and look from start - 1 to 0 each time
            if it's negative, start from start
    */
    public static int[] TwoSum(int[] numbers, int target)
    {
        var arrayOfIndices = new int[2];

        if (numbers == null) return arrayOfIndices;

        // Since it's sorted, you can cut the array in half
        var numbersLength = numbers.Length;
        var numbersMid = numbers.Length / 2;
        var startIndex = numbers.Length - 1;

        // This can be improved to be smarter
        // start index is the number before the first one that is bigger than k
        if (numbers[numbersMid] > Math.Abs(target))
        {
            startIndex = numbersMid;
        }

        if (target > 0)
        {
            for (var i = startIndex; i > 0; i--)
            {
                var current = numbers[i];

                for (var j = i - 1; j >= 0; j--)
                {
                    if (current + numbers[j] == target)
                    {
                        arrayOfIndices[0] = j + 1;
                        arrayOfIndices[1] = i + 1;
                        goto readyToReturn;
                    }
                }
            }
        }
        else
        {
            for (var i = 0; i < numbersLength; i++)
            {
                var current = numbers[i];

                for (var j = i + 1; j < numbersLength; j++)
                {
                    if (current + numbers[j] == target)
                    {
                        arrayOfIndices[0] = i + 1;
                        arrayOfIndices[1] = j + 1;
                        goto readyToReturn;
                    }
                }
            }
        }

    readyToReturn: return arrayOfIndices;
    }
}