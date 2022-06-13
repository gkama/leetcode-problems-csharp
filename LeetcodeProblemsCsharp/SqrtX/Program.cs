var exs = new List<int>
{
    4,
    8
};

foreach (var ex in exs)
{
    Console.WriteLine($"{ex} -> {Solution.MySqrt(ex)}");
}