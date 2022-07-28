/*
 * Given a binary tree return all the values you’d be able to see if you were standing on the left side of it with values ordered from top to bottom.
 * 
 * Ex: Given the following tree…
 */

public static class Solution
{
    public class TreeNode
    {
        public int val { get; set; }
        public TreeNode left { get; set; }
        public TreeNode right { get; set; }
    }

    public static List<int> VisibleValuesV2(TreeNode root)
    {
        var res = new List<int>();
        var stack = new Stack<TreeNode>();

        stack.Push(root);

        while (stack.Count() > 0)
        {
            var next = stack.Pop();

            res.Add(next.val);

            if (next.left != null) stack.Push(next.left);
        }

        return res;
    }

    public static List<int> VisibleValuesV1(TreeNode root)
    {
        var res = new List<int>();
        var queue = new Queue<TreeNode>();

        queue.Enqueue(root);

        while (queue.Count() > 0)
        {
            var size = queue.Count();

            for (var i = 0; i < size; i++)
            {
                var next = queue.Dequeue();

                if (i == 0) res.Add(next.val);

                if (next.left != null) queue.Enqueue(next.left);
            }
        }

        return res;
    }

    public static void ExamplesV1()
    {
        var exs = new List<TreeNode>
        {
            new TreeNode { val = 4, left = new TreeNode { val = 2 }, right = new TreeNode { val = 7} },
            new TreeNode { val = 4, left = new TreeNode { val = 2, left = new TreeNode { val = 1 } }, right = new TreeNode { val = 7} }
        };

        foreach (var ex in exs)
        {
            Console.WriteLine($"[{string.Join(", ", VisibleValuesV1(ex))}]");
        }
    }

    public static void ExamplesV2()
    {
        var exs = new List<TreeNode>
        {
            new TreeNode { val = 4, left = new TreeNode { val = 2 }, right = new TreeNode { val = 7} },
            new TreeNode { val = 4, left = new TreeNode { val = 2, left = new TreeNode { val = 1 } }, right = new TreeNode { val = 7} }
        };

        foreach (var ex in exs)
        {
            Console.WriteLine($"[{string.Join(", ", VisibleValuesV1(ex))}]");
        }
    }
}
