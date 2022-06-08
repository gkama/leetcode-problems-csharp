namespace DataStructures
{
    public abstract class Heap
    {
        public abstract bool IsValid();
        public abstract void Initialize();
        public abstract void Print();
    }

    public class Node<T>
    {
        public T? Value { get; set; }
        public Node<T>? Left { get; set; }
        public Node<T>? Right { get; set; }
    }
}
