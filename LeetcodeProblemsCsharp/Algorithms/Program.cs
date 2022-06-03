var array = new int[] { 3, 6, 5, 2, 1, 7, 4, 9, 8 };

var selectionSort = SelectionSort.Sort(array);

//Console.WriteLine("Selection sort");
//foreach (var res in selectionSort)
//    Console.Write($"{res} ");

Console.WriteLine("DFS search");
var searched = Dfs.SearchWithSample("A", "G");
foreach (var res in searched)
    Console.Write($"{res} ");