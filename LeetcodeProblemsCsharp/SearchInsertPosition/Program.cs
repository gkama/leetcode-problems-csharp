var exs = new Dictionary<int[], int>
{
    { new int[] { 1, 3, 5, 6 }, 5 },
    { new int[] { 1, 3, 5, 6 }, 2 },
    { new int[] { 1, 3, 5, 6 }, 7 },
    { new int[] { 1, 2, 3, 4, 5, 6 }, 7 },
    { new int[] { 1, 3, 5, 6 }, 0 },
    { new int[] { 1, 3 }, 2 }
};

foreach (var ex in exs)
{
    Console.WriteLine($"{ex.Value} into {string.Join(",", ex.Key)} -> {Solution.SearchInsert(ex.Key, ex.Value)}");
}