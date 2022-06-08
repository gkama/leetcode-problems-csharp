var exs = new List<int[]>
{
    new int[] { 1, 2, 3, 1 },
    new int[] { 1, 2, 3, 4 },
    new int[] { 1, 1, 1, 3, 3, 4, 3, 2, 4, 2 }
};


foreach (var ex in exs)
{
    Console.WriteLine($"{string.Join(",", ex)} -> {Solution.ContainsDuplicate(ex)}");
}