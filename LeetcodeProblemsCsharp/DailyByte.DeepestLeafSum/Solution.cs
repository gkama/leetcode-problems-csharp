/*
 * Given the reference to the root of a binary tree, return the sum of all leaves at the deepest level.
 * 
 * Ex: Given the following tree…
 *
 *      2
 *     / \
 *    4   5, return 9 (4 and 5 are at the deepest level and sum to 9).
 *    
 * Ex: Given the following tree…
 *
 *      1
 *       \
 *        2
 *         \
 *          3, return 3.
 */

public static class Solution
{
    public class TreeNode
    {
        public int Value { get; set; }
        public TreeNode? Left { get; set; }
        public TreeNode? Right { get; set; }
        public bool IsLeaf => Left == null && Right == null;
    }

    public static int DeepestLeafSum(TreeNode root)
    {
        if (root == null) return 0;

        var leaves = new List<int>();
        var queue = new Queue<TreeNode>();

        queue.Enqueue(root);

        while (queue.Count > 0)
        {
            var next = queue.Dequeue();

            if (next.IsLeaf) leaves.Add(next.Value);

            if (next.Left != null) queue.Enqueue(next.Left);
            if (next.Right != null) queue.Enqueue(next.Right);
        }

        var sum = 0;

        for (var i = 0; i < leaves.Count; i++)
        {
            sum += leaves[i];
        }

        return sum;
    }

    public static int DeepestLeafSumV2(TreeNode root)
    {
        if (root == null) return 0;

        var leaves = new List<int>();
        var stack = new Stack<TreeNode>();

        stack.Push(root);

        while (stack.Count > 0)
        {
            var next = stack.Pop();

            if (next.IsLeaf) leaves.Add(next.Value);

            if (next.Left != null) stack.Push(next.Left);
            if (next.Right != null) stack.Push(next.Right);
        }

        var sum = 0;

        for (var i = 0; i < leaves.Count; i++)
        {
            sum += leaves[i];
        }

        return sum;
    }

    public static void Examples()
    {
        var exs = new List<TreeNode>
        {
            new TreeNode { Value = 2, Left = new TreeNode { Value = 4 }, Right = new TreeNode { Value = 5 } },
            new TreeNode { Value = 1, Right = new TreeNode { Value = 2, Right = new TreeNode { Value = 3 } } },
            new TreeNode { Value = 1, Right = new TreeNode { Value = 2, Right = new TreeNode { Value = 3 } }, Left = new TreeNode { Value = 3 } }
        };

        foreach (var ex in exs)
        {
            Console.WriteLine($"= {DeepestLeafSumV2(ex)}");
        }
    }
}