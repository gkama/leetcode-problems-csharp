// https://leetcode.com/problems/valid-sudoku/
public static class Solution
{
    /*
    Alg
        keep track of each row
        keep track of each col
        keep track of each 3x3 sub-box
            i from 0 to 3
            j from 0 to 3
            each 3 is a sub-box
        each of those can be arrays
        each one must not have duplicates
        
    */
    public static bool IsValidSudoku(char[][] board)
    {
        var rows = new char[9][];
        var cols = new char[9][];
        var subboxes = new char[9][];

        var rowLength = board.GetLength(0);

        // Initialize jagged arrays
        for (var i = 0; i < 9; i++)
        {
            rows[i] = new char[9];
            cols[i] = new char[9];
            subboxes[i] = new char[9];
        }

        int sbRow = -1, sbColumn = 0;

        // Populate the rows and cols
        for (var i = 0; i < rowLength; i++)
        {
            for (var j = 0; j < board[i].Length; j++)
            {
                sbRow = i;
                sbColumn = (3 * i) % 9 + j % 3;

                if (sbRow < 3)
                {
                    sbRow = 0;
                }
                else if (sbRow < 6)
                {
                    sbRow = 3;
                }
                else
                {
                    sbRow = 6;
                }

                sbRow += j / 3;

                if (board[i][j] != '.')
                {
                    rows[i][j] = board[i][j];
                    cols[j][i] = board[i][j];
                    subboxes[sbRow][sbColumn] = board[i][j];
                }
            }
        }

        // Check each row
        // Check each col
        // Check each sub-box
        for (var i = 0; i < rows.GetLength(0); i++)
        {
            // To hashset and check size
            var digitRow = rows[i].Where(x => char.IsDigit(x));
            var digitCol = cols[i].Where(x => char.IsDigit(x));
            var digitSubBox = subboxes[i].Where(x => char.IsDigit(x));

            Console.WriteLine($"Row: {string.Join(", ", digitRow)}");
            Console.WriteLine($"Col: {string.Join(", ", digitCol)}");
            Console.WriteLine($"Sub-box: {string.Join(", ", digitSubBox)}");

            if (digitRow.ToHashSet().Count() != digitRow.Count()) return false;
            if (digitCol.ToHashSet().Count() != digitCol.Count()) return false;
            if (digitSubBox.ToHashSet().Count() != digitSubBox.Count()) return false;
        }

        return true;
    }
}