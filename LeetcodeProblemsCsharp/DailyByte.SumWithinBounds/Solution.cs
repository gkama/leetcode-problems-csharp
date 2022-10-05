/*
 * This question is asked by Facebook. Given the root of a binary tree and two values low and high return the sum of all values in the tree that are within low and high.
 * 
 * Ex: Given the following tree where low = 3 and high = 5…
 *          1
 *         / \
 *        7   5
 *       /    / \
 *      4    3   9
 * return 12 (3, 4, and 5 are the only values within low and high and they sum to 12)
 */
public static class Solution
{
    public class TreeNode
    {
        public int Val { get; set; }
        public TreeNode? Left { get; set; }
        public TreeNode? Right { get; set; }
    }

    public static int SumWithinBounds(TreeNode root, int low, int high)
    {
        var sum = 0;

        if (root == null) return sum;

        var queue = new Queue<TreeNode>();
        queue.Enqueue(root);

        while (queue.Count() > 0)
        {
            var next = queue.Dequeue();

            if (next.Val <= high && next.Val >= low)
            {
                sum += next.Val;
            }

            if (next.Left != null) queue.Enqueue(next.Left);
            if (next.Right != null) queue.Enqueue(next.Right);
        }

        return sum;
    }

    public class Example
    {
        public TreeNode? Root { get; set; }
        public int Low { get; set; }
        public int High { get; set; }
    }
    public static void Examples()
    {
        var exs = new List<Example>
        {
            new Example
            {
                Root = new TreeNode { Val = 1, Left = new TreeNode { Val = 7, Left = new TreeNode { Val = 4 } }, Right = new TreeNode { Val = 5, Left = new TreeNode { Val = 3 }, Right = new TreeNode { Val = 9 } } },
                Low = 3,
                High = 5
            }
        };

        foreach (var ex in exs)
        {
            Console.WriteLine($"{SumWithinBounds(ex.Root!, ex.Low, ex.High)}");
        }
    }
}
