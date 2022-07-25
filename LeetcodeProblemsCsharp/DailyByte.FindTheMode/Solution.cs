/*
 * Given a binary search tree, return its mode (you may assume the answer is unique). If the tree is empty, return -1. Note: the mode is the most frequently occurring value in the tree.
 * 
 * Ex: Given the following tree...
 *          2
 *         / \
 *        1   2
 *        return 2.
 */
public static class Solution
{
    public class Node
    {
        public int val { get; set; }
        public Node left { get; set; }
        public Node right { get; set; }
    }

    public static int FindMode(Node tree)
    {
        if (tree == null) return -1;

        var dict = new Dictionary<int, int>();
        var queue = new Queue<Node>(); //BFS

        queue.Enqueue(tree);

        while (queue.Count() > 0)
        {
            var next = queue.Dequeue();

            if (dict.ContainsKey(next.val)) dict[next.val] += 1;
            else dict.Add(next.val, 1);

            if (next.left != null) queue.Enqueue(next.left);
            if (next.right != null) queue.Enqueue(next.right);
        }

        return dict.OrderByDescending(x => x.Value)
            .First()
            .Key;
    }

    public static void Examples()
    {
        var exs = new List<Node>
        {
            new Node { val = 2, left = new Node { val = 1 }, right = new Node { val = 2 } },
            new Node { val = 7, left = new Node { val = 4, left = new Node { val = 1 }, right = new Node { val = 4 } }, right = new Node { val = 9, left = new Node { val = 8 }, right = new Node { val = 9, right = new Node { val = 9 } } } },
            new Node { val = 1, left = new Node { val = 1 }, right = new Node { val = 1 } },
        };

        foreach (var ex in exs)
        {
            Console.WriteLine($"{FindMode(ex)}");
        }
    }
}
