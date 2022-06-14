using DataStructures;

var maxHeap = new MaxHeap();

Console.WriteLine("Max Heap");
if (maxHeap.IsValid())
{
    maxHeap.PrintDFS();
    Console.WriteLine("----");
    maxHeap.PrintBFS();
}

var minHeap = new MinHeap();

Console.WriteLine("Min Heap");
if (minHeap.IsValid())
{
    minHeap.PrintDFS();
    Console.WriteLine("----");
    minHeap.PrintBFS();
}