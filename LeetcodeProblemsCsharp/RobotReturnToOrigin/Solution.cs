// https://leetcode.com/problems/robot-return-to-origin/
public static class Solution
{
    public static bool JudgeCircle(string moves)
    {
        if (string.IsNullOrWhiteSpace(moves)) return true;

        var positionX = 0;
        var positionY = 0;
        var moveMagnitude = 1;
        var movesArray = moves.ToCharArray();

        // L, R is -1 or +1 on x
        // U, D is -1 or +1 on y
        for (var i = 0; i < movesArray.Length; i++)
        {
            var move = movesArray[i];
            if (move == 'L') positionX -= moveMagnitude;
            if (move == 'R') positionX += moveMagnitude;
            if (move == 'U') positionY += moveMagnitude;
            if (move == 'D') positionY -= moveMagnitude;
        }

        return positionX == 0 && positionY == 0;
    }

    public static bool JudgeCircle2(string moves)
    {
        if (string.IsNullOrWhiteSpace(moves)) return true;

        var movesArray = moves.ToCharArray();
        var lefts = movesArray.Where(c => c == 'L').Count();
        var rights = movesArray.Where(c => c == 'R').Count();
        var ups = movesArray.Where(c => c == 'U').Count();
        var downs = movesArray.Where(c => c == 'D').Count();

        return lefts == rights
            && ups == downs;
    }
}