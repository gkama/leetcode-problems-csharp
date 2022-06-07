var exs = new List<int[]>
{
    new int [] { 0,0,1,1,1,2,2,3,3,4 },
    new int [] { 0,0,0,0,0,0,1,2 },
    new int [] { 1,1,2 },
    new int [] {  },
    new int [] { 1 },
    new int [] { 1,1 }
};


foreach (var ex in exs)
{
    Console.WriteLine($"{string.Join(", ", ex)} -> {Solution.RemoveDuplicates(ex)}");
}