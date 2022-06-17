var array = new int[] { 3, 6, 5, 2, 1, 7, 4, 9, 8 };
var array1 = new int[] { 1, 11, 21, 23 };

var selectionSort = SelectionSort.Sort(array);

//Console.WriteLine("Selection sort");
//foreach (var res in selectionSort)
//    Console.Write($"{res} ");

//Console.WriteLine("DFS search");
//var searched = Dfs.SearchWithSample("A", "G");
//foreach (var res in searched)
//    Console.Write($"{res} ");

//var pos = 3;
//Console.WriteLine(new QuickSelect().Select(array1, 0, array1.Length - 1, pos - 1));

var sortedArray = new int[] { 1, 2, 3, 4, 5 };
foreach (var s in sortedArray)
{
    Console.WriteLine($"{s} -> {BinarySearch.Interative(sortedArray, s)}");
}
Console.WriteLine($"{10} -> {BinarySearch.Interative(sortedArray, 10)}");