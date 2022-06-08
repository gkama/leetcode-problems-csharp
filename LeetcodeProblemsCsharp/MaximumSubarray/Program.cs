var exs = new List<int[]>
{
    new int[] { -2, 1, -3, 4, -1, 2, 1, -5, 4 },
    new int[] { 1 },
    new int[] { 5, 4, -1, 7, 8 },
    new int[] { -2, 1 },
    new int[] { -2, -1 },
    new int[] { -1, 0, -2 }
};


foreach (var ex in exs)
{
    Console.WriteLine($"{string.Join(",", ex)} -> {Solution.MaxSubArray(ex)}");
}