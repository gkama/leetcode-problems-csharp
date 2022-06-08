namespace DataStructures
{
    /*
     * Max heap
     *  each node's value must be greater than or equal to its childrens' values
     */
    public class MaxHeap : Heap
    {
        public int Size { get; set; }

        public Node<int>? Head { get; set; }

        public MaxHeap()
        {
            Initialize();
        }

        public override void Initialize()
        {
            /*
             *          15
             *        /    \
             *       10    12
             *      / \
             *     8   9
             */
            Head = new Node<int>
            {
                Value = 15,
                Left = new Node<int>
                {
                    Value = 10,
                    Left = new Node<int>
                    {
                        Value = 8
                    },
                    Right = new Node<int>
                    {
                        Value = 9
                    }
                },
                Right = new Node<int>
                {
                    Value = 12
                }
            };
        }

        public override bool IsValid()
        {
            if (Head is null)
            {
                return false;
            }

            // DF approach
            var stack = new Stack<Node<int>>();
            stack.Push(Head);

            while (stack.Count > 0)
            {
                var next = stack.Pop();

                if (next.Left != null && next.Value < next.Left?.Value) return false;
                else if (next.Right != null && next.Value < next.Right?.Value) return false;
                else if (next.Left == null && next.Right != null) return false;

                if (next.Right != null) stack.Push(next.Right);
                if (next.Left != null) stack.Push(next.Left);
            }

            return true;
        }

        public override void Print()
        {
            // DF approach
            var stack = new Stack<Node<int>>();
            stack.Push(Head);

            while (stack.Count > 0)
            {
                var next = stack.Pop();

                Console.WriteLine(next.Value);

                if (next.Right != null) stack.Push(next.Right);
                if (next.Left != null) stack.Push(next.Left);
            }
        }
    }
}
