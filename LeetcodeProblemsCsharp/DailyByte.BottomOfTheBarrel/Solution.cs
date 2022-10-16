/*
 * Given a binary tree, return the bottom-left most value.
 * Note: You may assume each value in the tree is unique.
 * 
 * Ex: Given the following binary tree…
 *       1
 *      / \
 *     2   3
 *    /
 *   4 
 *  return 4.
 */
public static class Solution
{
    public class TreeNode
    {
        public int Val { get; set; }
        public TreeNode? Left { get; set; }
        public TreeNode? Right { get; set; }
    }

    public static int? BottomOfTheBarrel(TreeNode root)
    {
        if (root == null) return null;

        var queue = new Queue<TreeNode>();
        var leftMost = 0;
        queue.Enqueue(root);

        while (queue.Count() > 0)
        {
            var size = queue.Count();

            for (var i = 0; i < size; i++)
            {
                var next = queue.Dequeue();

                if (i == 0) leftMost = next.Val;

                if (next.Left != null) queue.Enqueue(next.Left);
                if (next.Right != null) queue.Enqueue(next.Right);
            }
        }

        return leftMost;
    }

    public static void Examples()
    {
        var exs = new List<TreeNode>
        {
            new TreeNode { Val = 1, Left = new TreeNode { Val = 2, Left = new TreeNode { Val = 4 } }, Right = new TreeNode { Val = 3 } },
            new TreeNode { Val = 1, Left = new TreeNode { Val = 2, Left = new TreeNode { Val = 4 }, Right = new TreeNode { Val = 9 } }, Right = new TreeNode { Val = 3 } },
            new TreeNode { Val = 8, Left = new TreeNode { Val = 1 }, Right = new TreeNode { Val = 4, Left = new TreeNode { Val = 2 } } }
        };

        foreach (var ex in exs)
        {
            Console.WriteLine($"{BottomOfTheBarrel(ex)}");
        }
    }
}
