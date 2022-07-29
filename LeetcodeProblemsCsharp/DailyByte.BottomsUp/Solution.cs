/*
 * Given a binary tree, returns of all its levels in a bottom-up fashion (i.e. last level towards the root). Ex: Given the following tree…
 */

public static class Solution
{
    public class TreeNode
    {
        public int val { get; set; }
        public TreeNode left { get; set; }
        public TreeNode right { get; set; }
    }

    public static List<List<int>> BottomsUp(TreeNode root)
    {
        var res = new List<List<int>>();
        var queue = new Queue<TreeNode>();

        queue.Enqueue(root);

        while (queue.Count() > 0)
        {
            var size = queue.Count();
            var innerRes = new List<int>();

            for (var i = 0; i < size; i++)
            {
                var next = queue.Dequeue();

                innerRes.Add(next.val);

                if (next.left != null) queue.Enqueue(next.left);
                if (next.right != null) queue.Enqueue(next.right);
            }

            res.Add(innerRes);
        }

        res.Reverse();

        return res;
    }

    public static void Examples()
    {
        var exs = new List<TreeNode>
        {
            new TreeNode { val = 2, left = new TreeNode { val = 1 }, right = new TreeNode { val = 2 } },
            new TreeNode { val = 7, left = new TreeNode { val = 6, left = new TreeNode { val = 3 }, right = new TreeNode { val = 3 } }, right = new TreeNode { val = 2 } }
        };

        foreach (var ex in exs)
        {
            var res = BottomsUp(ex);
            var resStrBuilder = new System.Text.StringBuilder();

            for (var i = 0; i < res.Count(); i++)
            {
                resStrBuilder.Append($"[{string.Join(", ", res[i])}]{(i == res.Count() - 1 ? "" : ", ")}");
            }

            Console.WriteLine($"{resStrBuilder}");
        }
    }
}