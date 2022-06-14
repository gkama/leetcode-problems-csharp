// https://leetcode.com/problems/reshape-the-matrix/
public static class Solution
{
    public static int[][] MatrixReshape(int[][] mat, int r, int c)
    {
        // Check if possible to recreate r x c
        var rows = mat.GetLength(0);
        var cols = mat[0].Length;

        if (rows * cols < r * c)
        {
            return mat;
        }

        int[][] toReturn = new int[r][];

        for (var k = 0; k < toReturn.GetLength(0); k++)
        {
            toReturn[k] = new int[c];
        }

        var iRow = 0;
        var iCol = 0;

        for (int i = 0; i < r; i++)
        {
            for (int j = 0; j < c; j++)
            {
                if ((iRow < rows) || (iCol < cols))
                {
                    if (iCol >= cols)
                    {
                        iCol = 0;
                        iRow++;
                    }
                    toReturn[i][j] = mat[iRow][iCol++];
                }
            }
        }

        return toReturn;
    }
}
