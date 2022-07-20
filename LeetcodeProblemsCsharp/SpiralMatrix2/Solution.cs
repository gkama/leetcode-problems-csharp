//https://leetcode.com/problems/spiral-matrix-ii/
public static class Solution
{
    public static int[][] GenerateMatrix(int n)
    {
        /*
        start left and every time you hit index of n - 1, switch direction
        right -> down
        down -> left
        left -> up
        up -> right
        */
        var res = new int[n][];

        for (var i = 0; i < n; i++)
        {
            res[i] = new int[n];
        }

        int left = 0, up = 0;
        int right = n - 1, down = n - 1;
        int count = 1;

        while (left <= right)
        {
            // Top
            for (int j = left; j <= right; j++)
            {
                res[up][j] = count++;
            }
            up++;

            // Right
            for (int i = up; i <= down; i++)
            {
                res[i][right] = count++;
            }
            right--;

            // Down
            for (int j = right; j >= left; j--)
            {
                res[down][j] = count++;
            }
            down--;

            // Left
            for (int i = down; i >= up; i--)
            {
                res[i][left] = count++;
            }
            left++;
        }

        return res;
    }
}