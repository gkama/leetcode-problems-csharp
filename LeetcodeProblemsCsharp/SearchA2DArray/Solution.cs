// https://leetcode.com/problems/search-a-2d-matrix/
public static class Solution
{
    /*
    Alg
        for each row, check first and last element
        if the target is bigger than first and less than last then it's in that row
            this way we can nail it down to a specific row, then we can ignore the rest
            if the target is greater than the last element but smaller than the next row's first, then it doesn't exist
            if the target is smaller than the very first element, it doesn't exist
        then perform binary search on the row to find the value
    */
    public static bool SearchMatrix(int[][] matrix, int target)
    {
        var rows = matrix.GetLength(0);

        if (rows < 1) return false;
        else if (matrix[0][0] > target) return false;

        var arrayToSearchIn = new int[rows];

        for (var i = 0; i < rows; i++)
        {
            var first = matrix[i][0];
            var last = matrix[i][matrix[i].Length - 1];

            if (first == target) return true;
            else if (last == target) return true;
            else if (first > target) return false;
            else if (first < target && last > target)
            {
                arrayToSearchIn = matrix[i];
                break;
            }
        }

        if (matrix[rows - 1][matrix[rows - 1].Length - 1] < target) return false;

        // Now that we have the row
        // we're aready at O(m) here
        // perform the search on a sorted array
        var arrayToSearchInLen = arrayToSearchIn.Length;
        var min = 0;
        var max = arrayToSearchInLen - 1;
        var maxIterations = arrayToSearchInLen / 2 + 1;
        var currIterations = 0;

        bool InternalSearch(int[] array, int min, int max, int target)
        {
            if (currIterations == maxIterations) return false;

            var mid = (min + max) / 2;
            Console.WriteLine(mid);

            if (array[mid] == target)
            {
                return true;
            }
            else if (array[mid] > target)
            {
                currIterations++;
                return InternalSearch(array, min, mid - 1, target);
            }
            else
            {
                currIterations++;
                return InternalSearch(array, mid + 1, max, target);
            }

            return false;
        }

        return InternalSearch(arrayToSearchIn, min, max, target);
    }
}