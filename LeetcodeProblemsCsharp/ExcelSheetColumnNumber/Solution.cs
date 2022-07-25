// https://leetcode.com/problems/excel-sheet-column-number/
public static class Solution
{
    private const string _cols = "abcdefghijklmnopqrstuvwxyz";
    private const int _alphabetLetters = 26;

    public static int TitleToNumber(string columnTitle)
    {
        var titleNumber = 0;
        var columnTitleArray = columnTitle.ToCharArray();

        for (var i = 0; i < columnTitleArray.Length - 1; i++)
        {
            titleNumber += (columnTitleArray[i] - 'A' + 1)
                * (int)Math.Pow(_alphabetLetters, columnTitleArray.Length - 1 - i);
        }

        return titleNumber + GetPos(columnTitleArray[columnTitleArray.Length - 1]);
    }

    private static int GetPos(char col)
    {
        return _cols.IndexOf(col.ToString().ToLower()) + 1;
    }
}