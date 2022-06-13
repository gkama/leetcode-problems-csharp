var exs = new List<int>
{
    2,
    100
};

foreach (var ex in exs)
{
    Console.WriteLine($"{ex} -> {Solution.TwoEggDrop(ex)}");
}