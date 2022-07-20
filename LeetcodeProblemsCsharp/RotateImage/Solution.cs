// https://leetcode.com/problems/rotate-image/
public static class Solution
{
    public static void Rotate(int[][] matrix)
    {
        
    }

    public static void RotateV1(int[][] matrix)
    {
        if (matrix == null) return;

        var size = matrix.Length;

        // Rotate n - 1 places
        // The row becomes the column at the outer

        // Row 0 example
        var rowBeginning = matrix[0];
        var rowEnd = matrix[size - 1];
        var colBeginning = new int[size];
        var colEnd = new int[size];
        var colEndIndex = 0;
        var colBeginningIndex = 0;

        // End
        for (var i = 0; i < rowEnd.Length; i++)
        {
            var temp = matrix[colEndIndex][size - 1];
            matrix[colEndIndex][size - 1] = matrix[0][i];

            // Populate col end
            colEnd[colEndIndex] = temp;

            colEndIndex++;
        }

        // Beginning
        for (var i = 0; i < colBeginning.Length; i++)
        {
            var temp = matrix[colBeginningIndex][0];
            matrix[colBeginningIndex][0] = matrix[0][i];

            // Populate col end
            colBeginning[colBeginningIndex] = temp;

            colBeginningIndex++;
        }

        // Update bottom row
        var rowEndIndex = 0;
        for (var i = colEnd.Length - 1; i >= 0; i--)
        {
            matrix[size - 1][i] = colEnd[rowEndIndex];
            rowEndIndex++;
        }

        // Update first row
        var rowBeginningIndex = 0;
        for (var i = colBeginning.Length - 1; i >= 0; i--)
        {
            matrix[0][i] = colBeginning[rowBeginningIndex];
            rowBeginningIndex++;
        }
    }
}