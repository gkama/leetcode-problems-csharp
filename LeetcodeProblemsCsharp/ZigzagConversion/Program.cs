var exs = new Dictionary<int, string>
{
    { 1, "AB" },
    { 2, "AB" },
    { 3, "PAYPALISHIRING" },
    { 4, "PAYPALISHIRING" }
};

foreach (var ex in exs)
{
    Console.WriteLine($"{ex.Key} rows {ex.Value} -> {Solution.Convert(ex.Value, ex.Key)}");
}