var exs = new List<int[]>
{
    new int[] { 1, 2, 3 },
    new int[] { 4, 3, 2, 1 },
    new int[] { 1, 2, 3, 9 },
    new int[] { 1, 2, 3, 9, 9 },
    new int[] { 9, 9, 9 },
    new int[] { 9 },
    new int[] { 1 },
};

foreach (var ex in exs)
{
    Console.WriteLine($"{string.Join(",", ex)} -> {string.Join(",", Solution.PlusOne(ex))}");
}