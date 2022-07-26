/*
 * Given a binary tree, return its level order traversal where the nodes in each level are ordered from left to right.
 */
public static class Solution
{
    public class TreeNode
    {
        public int val { get; set; }
        public TreeNode left { get; set; }
        public TreeNode right { get; set; }
    }

    public static List<List<int>> GatherLevels(TreeNode root)
    {
        var res = new List<List<int>>();
        var queue = new Queue<TreeNode>();

        queue.Enqueue(root);

        while (queue.Count() > 0)
        {
            var size = queue.Count();
            var levelOrder = new List<int>();

            for (var i = 0; i < size; i++)
            {
                var next = queue.Dequeue();
                levelOrder.Add(next.val);

                if (next.left != null) queue.Enqueue(next.left);
                if (next.right != null) queue.Enqueue(next.right);
            }

            res.Add(levelOrder);
        }

        return res;
    }

    public static void Examples()
    {
        var exs = new List<TreeNode>
        {
            new TreeNode { val = 4, left = new TreeNode { val = 2 }, right = new TreeNode { val = 7 } },
            new TreeNode { val = 2, left = new TreeNode { val = 10 }, right = new TreeNode { val = 15, right = new TreeNode { val = 20 } } },
            new TreeNode { val = 1, left = new TreeNode { val = 9, left = new TreeNode { val = 3 } }, right = new TreeNode { val = 32, right = new TreeNode { val = 78 } } },
            new TreeNode { val = 4, left = new TreeNode { val = 2, left = new TreeNode { val = 1 }, right = new TreeNode { val = 3 } }, right = new TreeNode { val = 7, left = new TreeNode { val = 5 }, right = new TreeNode { val = 9 } } },
        };

        foreach (var ex in exs)
        {
            var res = GatherLevels(ex);
            foreach (var r in res)
            {
                Console.Write($"[{string.Join(", ", r)}] ");
            }
            Console.WriteLine();
        }
    }
}
