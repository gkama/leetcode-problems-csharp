/*
 * Given a binary tree, return the largest value in each of its levels. Ex: Given the following tree…
 */
public static class Solution
{
    public class TreeNode
    {
        public int val { get; set; }
        public TreeNode left { get; set; }
        public TreeNode right { get; set; }
    }

    public static List<int> MaxValueInEachLevel(TreeNode root)
    {
        var res = new List<int>();

        if (root == null) return res;

        var queue = new Queue<TreeNode>();

        queue.Enqueue(root);

        while (queue.Count() > 0)
        {
            var size = queue.Count();
            var biggest = int.MinValue;

            for (var i = 0; i < size; i++)
            {
                var next = queue.Dequeue();
                if (biggest < next.val) biggest = next.val;

                if (next.left != null) queue.Enqueue(next.left);
                if (next.right != null) queue.Enqueue(next.right);
            }

            res.Add(biggest);
        }

        return res;
    }

    public static void Examples()
    {
        var exs = new List<TreeNode>
        {
            new TreeNode { val = 2, left = new TreeNode { val = 10 }, right = new TreeNode { val = 15, right = new TreeNode { val = 20 } } },
            new TreeNode { val = 1, left = new TreeNode { val = 5, left = new TreeNode { val = 5 }, right = new TreeNode { val = 3 } }, right = new TreeNode { val = 6, right = new TreeNode { val = 7 } } },
            new TreeNode { val = 125, left = new TreeNode { val = 90, left = new TreeNode { val = 54 }, right = new TreeNode { val = 114 } }, right = new TreeNode { val = 187, left = new TreeNode { val = 160 }, right = new TreeNode { val = 457 } } },
        };

        foreach (var ex in exs)
        {
            Console.WriteLine($"[{string.Join(", ", MaxValueInEachLevel(ex))}]");
        }
    }
}