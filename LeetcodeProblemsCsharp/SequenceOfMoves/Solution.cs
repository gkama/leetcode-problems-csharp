public static class Solution
{
    /*
     * Alg
     *  start position is 0
     *  only when going up or down, do we increment and decrement
     *  need to keep track of direction
     *  it's only possible if there are as many ups as there are downs
     *  if there are not, we can reject it
     */
    public static bool ReturnToOriginalPosition(string moves)
    {
        // L, R, U and D left, right, up and down
        if (string.IsNullOrWhiteSpace(moves)) return true;

        var movesArray = moves.ToCharArray();

        var ups = movesArray.Where(c => c == 'U');
        var downs = movesArray.Where(c => c == 'D');
        var lefts = movesArray.Where(c => c == 'L');
        var rights = movesArray.Where(c => c == 'R');

        if (lefts.Count() != rights.Count()) return false;
        if (ups.Count() != downs.Count()) return false;

        return true;
    }

    public static void Examples()
    {
        var exs = new List<string>
        {
            "LR",
            "URURD",
            "RUULLDRD"
        };

        foreach (var ex in exs)
        {
            Console.WriteLine($"{ex} -> {ReturnToOriginalPosition(ex)}");
        }
    }
}
