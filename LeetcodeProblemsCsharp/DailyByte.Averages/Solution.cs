/*
 * This question is asked by Facebook. Given a reference to the root of a binary tree, return a list containing the average value in each level of the tree.
 * 
 * Ex: Given the following binary tree…
 *        1
 *       / \
 *      6    8
 *     / \ 
 *    1   5 
 *    return [1.0, 7.0, 3.0]
 */
using System.Collections.Generic;

public static class Solution
{
    public class TreeNode
    {
        public int Val { get; set; }
        public TreeNode? Left { get; set; }
        public TreeNode? Right { get; set; }
    }

    public static List<double> Averages(TreeNode root)
    {
        var res = new List<double>();

        if (root == null) return res;

        var queue = new Queue<TreeNode>();
        queue.Enqueue(root);

        while (queue.Count() > 0)
        {
            var size = queue.Count();
            var sum = 0;
            var total = 0;

            for (var i = 0; i < size; i++)
            {
                var next = queue.Dequeue();

                sum += next.Val;
                total += 1;

                if (next.Left != null) queue.Enqueue(next.Left);
                if (next.Right != null) queue.Enqueue(next.Right);
            }

            res.Add(sum / total);
        }

        return res;
    }

    public static void Examples()
    {
        var exs = new List<TreeNode>()
        {
            new TreeNode { Val = 1, Left = new TreeNode { Val = 6, Left = new TreeNode { Val = 1 }, Right = new TreeNode { Val = 5 } }, Right = new TreeNode { Val = 8 } },
            new TreeNode { Val = 1, Left = new TreeNode { Val = 1, Left = new TreeNode { Val = 1 }, Right = new TreeNode { Val = 1 } }, Right = new TreeNode { Val = 1 } },
            new TreeNode { Val = 50, Left = new TreeNode { Val = 75, Left = new TreeNode { Val = 89 }, Right = new TreeNode { Val = 578 } }, Right = new TreeNode { Val = 1025 } }
        };

        foreach (var ex in exs)
        {
            Console.WriteLine($"{string.Join(", ", Averages(ex))}");
        }
    }
}
