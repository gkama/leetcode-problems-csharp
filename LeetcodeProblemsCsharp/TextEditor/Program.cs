var exs = new string[][]
{
    new string[] { "APPEND", "You'll never find a rainbow if you're looking down" },
    new string[] { "MOVE", "5" },
    new string[] { "BACKSPACE" },
    new string[] { "BACKSPACE" },
    new string[] { "BACKSPACE" }
};

Console.WriteLine($"{Solution.solution(exs)}");