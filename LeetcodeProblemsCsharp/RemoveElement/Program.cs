var exs = new Dictionary<int[], int>
{
    { new int [] { 3,2,2,3 }, 3 },
    { new int [] { 0,1,2,2,3,0,4,2 }, 2 }
};


foreach (var ex in exs)
{
    var res = Solution.RemoveElement(ex.Key, ex.Value);

    Console.WriteLine($"{ex.Key} from {string.Join(",", ex.Key)} -> {res}");
}