var exs = new List<IList<int>>
{
    new List<int> { 2 },
    new List<int> { 3, 4 },
    new List<int> { 6, 5, 7 },
    new List<int> { 4, 1, 8, 3 }
};

Console.WriteLine($"{Solution.MinimumTotal(exs)}");