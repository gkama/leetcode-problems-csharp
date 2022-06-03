public static class SelectionSort
{
    public static int[] Sort(int[] unsortedArray)
    {
        var unsortedArrayLen = unsortedArray.Length;

        for (int i = 0; i < unsortedArrayLen; i++)
        {
            var smallest = unsortedArray[i];
            var smallestIndex = i;

            for (int j = i + 1; j < unsortedArrayLen; j++)
            {
                var next = unsortedArray[j];
                if (next < smallest)
                {
                    smallest = next;
                    smallestIndex = j;
                }
            }

            // Swap
            var temp = unsortedArray[i];
            unsortedArray[i] = smallest;
            unsortedArray[smallestIndex] = temp;
        }

        return unsortedArray;
    }
}
