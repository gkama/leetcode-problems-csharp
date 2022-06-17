public static class BinarySearch
{
    public static int Interative(int[] array, int target)
    {
        var minIndex = 0;
        var maxIndex = array.Length - 1;

        while (minIndex <= maxIndex)
        {
            var midIndex = (minIndex + maxIndex) / 2;

            if (array[midIndex] == target)
            {
                return midIndex;
            }
            else if (array[midIndex] > target) // Lower half
            {
                maxIndex = midIndex - 1;
            }
            else
            {
                minIndex = midIndex + 1;
            }
        }

        return -1;
    }
}
