using DataStructures;

var maxHeap = new MaxHeap();

if (maxHeap.IsValid())
{
    maxHeap.PrintDFS();
    Console.WriteLine("----");
    maxHeap.PrintBFS();
}