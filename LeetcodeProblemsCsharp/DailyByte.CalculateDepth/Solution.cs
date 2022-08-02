/*
 * Given a binary tree, return its maximum depth.
 * Note: the maximum depth is defined as the number of nodes along the longest path from root node to leaf node.
 */
public static class Solution
{
    public class TreeNode
    {
        public int val { get; set; }
        public TreeNode left { get; set; }
        public TreeNode right { get; set; }
    }

    public static int MaximumDepth(TreeNode root)
    {
        var depth = 0;

        if (root == null) return depth;

        var queue = new Queue<TreeNode>();

        queue.Enqueue(root);

        while (queue.Count() > 0)
        {
            var size = queue.Count();

            for (var i = 0; i < size; i++)
            {
                var next = queue.Dequeue();

                if (next.left != null) queue.Enqueue(next.left);
                if (next.right != null) queue.Enqueue(next.right);
            }

            depth++;
        }

        return depth;
    }

    public static void Examples()
    {
        var exs = new List<TreeNode>
        {
            new TreeNode { val = 9, left = new TreeNode { val = 1 }, right = new TreeNode { val = 2} },
            new TreeNode { val = 5, left = new TreeNode { val = 1 }, right = new TreeNode { val = 29, left = new TreeNode { val = 4 }, right = new TreeNode { val = 13 } } }
        };

        foreach (var ex in exs)
        {
            Console.WriteLine(MaximumDepth(ex));
        }
    }
}
