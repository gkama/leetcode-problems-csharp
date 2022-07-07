// https://leetcode.com/problems/pascals-triangle-ii/
public static class Solution
{
    public static IList<int> GetRow(int rowIndex)
    {
        // Pascal's triangle is a jagged array
        var pascalsTriangle = new int[rowIndex + 1][];

        // Initialize the inner arrays and one's
        for (var i = 0; i < rowIndex + 1; i++)
        {
            pascalsTriangle[i] = new int[i + 1];
            pascalsTriangle[i][0] = 1; // First
            pascalsTriangle[i][i] = 1; // Last

            // Iterate and populate the inner
            if (i > 1)
            {
                for (var j = 1; j < i; j++)
                {
                    pascalsTriangle[i][j] = pascalsTriangle[i - 1][j - 1] + pascalsTriangle[i - 1][j];
                }
            }
        }

        return pascalsTriangle[rowIndex];
    }
}