namespace DataStructures
{
    /*
     * Min heap
     *  each node's value must be less than or equal to its childrens' values
     */
    public class MinHeap : Heap
    {
        public int Size { get; set; }

        public Node<int>? Head { get; set; }

        public MinHeap()
        {
            Initialize();
        }

        public override void Initialize()
        {
            /*
             *         2
             *       /   \
             *      4     3
             *     / \   /  \
             *    6   5  7   8
             */
            Head = new Node<int>
            {
                Value = 2,
                Left = new Node<int>
                {
                    Value = 4,
                    Left = new Node<int>
                    {
                        Value = 6
                    },
                    Right = new Node<int>
                    {
                        Value = 5
                    }
                },
                Right = new Node<int>
                {
                    Value = 3,
                    Left = new Node<int>
                    {
                        Value = 7
                    },
                    Right = new Node<int>
                    {
                        Value = 8
                    }
                }
            };
        }

        public override bool IsValid()
        {
            var queue = new Queue<Node<int>>();
            queue.Enqueue(Head);

            while (queue.Count > 0)
            {
                var next = queue.Dequeue();

                if (next.Right is not null && next.Left is null) return false;
                if (next.Right is not null && next.Value > next.Right.Value) return false;
                if (next.Left is not null && next.Value > next.Left.Value) return false;

                if (next.Left is not null) queue.Enqueue(next.Left);
                if (next.Right is not null) queue.Enqueue(next.Right);
            }

            return true;
        }

        public override void PrintBFS()
        {
            var queue = new Queue<Node<int>>();
            queue.Enqueue(Head);
            
            while (queue.Count > 0)
            {
                var next = queue.Dequeue();

                Console.WriteLine(next.Value);

                if (next.Left is not null) queue.Enqueue(next.Left);
                if (next.Right is not null) queue.Enqueue(next.Right);
            }
        }

        public override void PrintDFS()
        {
            var stack = new Stack<Node<int>>();
            stack.Push(Head);

            while (stack.Count > 0)
            {
                var next = stack.Pop();

                Console.WriteLine(next.Value);

                if (next.Right is not null) stack.Push(next.Right);
                if (next.Left is not null) stack.Push(next.Left);
            }
        }

        public override void Print()
        {
            PrintDFS();
        }
    }
}
