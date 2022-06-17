// https://leetcode.com/problems/reshape-the-matrix/
public static class Solution
{
    public static int[][] MatrixReshape(int[][] mat, int r, int c)
    {
        int curRows = mat.Length;
        int curColumns = mat[0].Length;

        if ((curRows * curColumns) == (r * c))
        {
            int[][] result = new int[r][];

            for (int i = 0; i < r; i++)
            {
                result[i] = new int[c];
            }
            int x = 0, y = 0;
            for (int i = 0; i < r; i++)
            {
                for (int j = 0; j < c; j++)
                {
                    if ((x < curRows) || (y < curColumns))
                    {
                        if (y >= curColumns)
                        {
                            y = 0;
                            x++;
                        }
                        result[i][j] = mat[x][y++];
                    }
                }
            }
            return result;
        }

        return mat;
    }
}
