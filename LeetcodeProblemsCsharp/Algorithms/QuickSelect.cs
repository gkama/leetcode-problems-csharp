
/*
 * In computer science, quickselect is a selection algorithm to find the kth smallest element in an unordered list. 
 * It is related to the quicksort sorting algorithm. Like quicksort, it was developed by Tony Hoare, and thus is also known as Hoare's selection algorithm.
 * 
 * Worst case O(n^2)
 * Average case O(n)
 * Data Structure array
 */
public class QuickSelect
{
    public int Select(int[] array, int low, int high, int k)
    {
        var partition = Partitions(array, low, high);

        if (partition == k)
        {
            return array[partition];
        }
        else if (partition < k)
        {
            return Select(array, partition + 1, high, k);
        }
        else
        {
            return Select(array, low, partition - 1, k);
        }
    }

    private int Partitions(int[] array, int low, int high)
    {
        int pivot = array[high];
        int pivotloc = low;
        int temp;

        for (int i = low; i <= high; i++)
        {
            // inserting elements of less value
            // to the left of the pivot location
            if (array[i] < pivot)
            {
                temp = array[i];
                array[i] = array[pivotloc];
                array[pivotloc] = temp;
                pivotloc++;
            }
        }

        // swapping pivot to the readonly pivot location
        temp = array[high];
        array[high] = array[pivotloc];
        array[pivotloc] = temp;

        return pivotloc;
    }
}
