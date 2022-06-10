// https://leetcode.com/problems/zigzag-conversion/
using System.Text;

public class Solution
{
    /*
     * Alg
     *      sotre in 2d array
     *      
     *      for example
     *          arr[][]
     *          for number of rows
     *          arr[0][0] = P
     *          arr[1][0] = A
     *          arr[2][0] = Y
     *          
     *          now we need to go diagonally back up
     *          arr[1][2] = P - 1 space
     *          arr[0][4] = A - 3 spaces
     *          
     *          then straight down
     *          arr[1][4] = L
     *          arr[2][4] = I
     *          
     *          then diagonally back up again
     *          arr[2][4] = S - 1 space
     *          arr[2]
     */
    public static string Convert(string s, int numRows)
    {
        if (s.Length == 1 || numRows == 1) return s;

        var len = s.Length;
        var arr = new string[numRows, len];

        var indexRow = 0;
        var indexColumn = 0;
        var indexLetter = 0;
        var goingDown = true;

        // Since it's zig zagging, we need to manipulate the index
        // One time it's going down, the next up
        while (indexRow >= 0 && indexRow <= numRows - 1)
        {
            if (indexLetter >= len)
            {
                goto createReturnedString;
            }

            arr[indexRow, indexColumn] = s[indexLetter].ToString();

            // Manipulating the row and column index
            if (indexRow == numRows - 1)
            {
                goingDown = false;
            }
            else if (indexRow == 0)
            {
                goingDown = true;
            }

            if (goingDown)
            {
                ++indexRow;
                ++indexLetter;
            }
            else
            {
                --indexRow;
                ++indexColumn;
                ++indexLetter;
            }
        }

        // Return it printed by row
        createReturnedString: var toPrint = new StringBuilder();
        for (var i = 0; i < arr.GetLength(0); i++)
        {
            for (var j = 0; j < arr.GetLength(1); j++)
            {
                if (!string.IsNullOrEmpty(arr[i, j]))
                {
                    toPrint.Append(arr[i, j]);
                }
            }
        }

        return toPrint.ToString();
    }
}
