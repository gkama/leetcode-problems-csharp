var exs = new Dictionary<int[], int[]>()
{
    { new int[] { 1, 2, 2, 1 }, new int[] { 2, 2 } },
    { new int[] { 4, 9, 5 }, new int[] { 9, 4, 9, 8, 4 } },
    { new int[] { 1, 2 }, new int[] { 2, 1 } },
    { new int[] { 1, 2 }, new int[] { 1, 1 } }
};

foreach (var ex in exs)
{
    Console.WriteLine($"{string.Join(", ", Solution.IntersectV2(ex.Key, ex.Value))}");
}