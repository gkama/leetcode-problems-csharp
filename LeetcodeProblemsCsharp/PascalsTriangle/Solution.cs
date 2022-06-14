// https://leetcode.com/problems/pascals-triangle/
public static class Solution
{
    /*
    Alg
        how do you define directly above it in an array of arrays structure?
        you create the pascal triangle
        1st row is always 1
        2nd row is always [1, 1]
        each row's first and last element is always 1
            pre-populate pascal's triangle for first 2 rows
    */
    public static IList<IList<int>> Generate(int numRows)
    {
        var pascalsTriangle = new int[numRows][];

        if (numRows == 0) return pascalsTriangle;
        pascalsTriangle[0] = new int[] { 1 };
        if (numRows == 1) return pascalsTriangle;
        pascalsTriangle[1] = new int[] { 1, 1 };
        if (numRows == 2) return pascalsTriangle;

        for (var i = 2; i < numRows; i++)
        {
            pascalsTriangle[i] = new int[i + 1];
            pascalsTriangle[i][0] = 1;
            pascalsTriangle[i][i] = 1;

            // Iterate through the middle (minus first and last)
            for (var j = 1; j < i; j++)
            {
                // Sum of the numbers directly above it
                //  directly above it is defined as
                //  go up, left and go up, right
                //  take the sum of the 2
                pascalsTriangle[i][j] = pascalsTriangle[i - 1][j - 1] + pascalsTriangle[i - 1][j];
            }
        }

        return pascalsTriangle;
    }
}