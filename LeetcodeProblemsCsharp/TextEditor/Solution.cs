public static class Solution
{
    public static string[] solution(string[][] queries)
    {
        var len = queries.Length;
        var result = new string[len];
        var currText = string.Empty;
        var cursor = 0;
        var numberOfMoves = 0;

        // Rows
        for (var i = 0; i < len; i++)
        {
            var subQueries = queries[i];

            // Command is always first
            var command = subQueries[0];

            // Text is always second
            var text = subQueries.Length > 1 ? subQueries[1] : null;

            if (command == "APPEND")
            {
                var lenOfResultI = currText.Length;
                var textBuilder = currText.Substring(0, cursor) + text + currText.Substring(cursor, lenOfResultI - cursor);

                result[i] = textBuilder;
                currText = result[i];
                cursor = currText.Length;
            }
            else if (command == "MOVE")
            {
                if (numberOfMoves == 0)
                {
                    cursor = 0;
                }

                cursor += int.Parse(text);

                var currTextLen = currText.Length;

                if (cursor >= currTextLen)
                {
                    cursor = currTextLen;
                }
                else if (cursor <= 0)
                {
                    cursor = 0;
                }

                result[i] = currText;
                numberOfMoves += 1;
            }
            else if (command == "BACKSPACE")
            {
                var lenOfResultI = currText.Length;
                result[i] = currText.Substring(0, cursor - 1) + currText.Substring(cursor, lenOfResultI - cursor);
                currText = result[i];
                cursor -= 1;
            }
        }

        return result.ToArray();
    }
}
