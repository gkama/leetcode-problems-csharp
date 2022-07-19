/*
 * This question is asked by Google. Given the reference to the root of a binary search tree and a search value, 
 * return the reference to the node that contains the value if it exists and null otherwise.
 * Note: all values in the binary search tree will be unique.
 * 
 * Ex: Given the tree...
 *          3
 *         / \
 *        1   4
 *        and the search value 1 return a reference to the node containing 1.
 */
public static class Solution
{
    public class Node
    {
        public int Value { get; set; }
        public Node? Left { get; set; }
        public Node? Right { get; set; }
    }

    public static Node? FindValue(Node? tree, int value)
    {
        if (tree == null) return null;

        var queue = new Queue<Node>();
        queue.Enqueue(tree);

        while (queue.Count() > 0)
        {
            var head = queue.Dequeue();

            if (head.Value == value)
                return head;

            if (head.Left != null) queue.Enqueue(head.Left);
            if (head.Right != null) queue.Enqueue(head.Right);
        }

        return null;
    }

    public static void Examples()
    {
        var exs = new Dictionary<Node, int>
        {
            { new Node { Value = 3, Left = new Node { Value = 1 }, Right = new Node { Value = 4 } }, 1 },
            { new Node { Value = 7, Left = new Node { Value = 5 }, Right = new Node { Value = 9, Left = new Node { Value = 8 }, Right = new Node { Value = 10 } } }, 9 },
            { new Node { Value = 8, Left = new Node { Value = 6 }, Right = new Node { Value = 9 } }, 7 },
        };

        foreach (var ex in exs)
        {
            Console.WriteLine($"{ex.Value} -> {Print(FindValue(ex.Key, ex.Value))}");
        }
    }

    private static string Print(Node? tree)
    {
        if (tree == null) return string.Empty;

        var queue = new Queue<Node>();
        var result = new System.Text.StringBuilder();

        queue.Enqueue(tree);

        while (queue.Count() > 0)
        {
            var head = queue.Dequeue();

            result.Append($"{head.Value}->");

            if (head.Left != null) queue.Enqueue(head.Left);
            if (head.Right != null) queue.Enqueue(head.Right);
        }

        return result.ToString();
    }
}
