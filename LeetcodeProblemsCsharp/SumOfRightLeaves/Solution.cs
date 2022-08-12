// https://leetcode.com/problems/sum-of-left-leaves/
public class TreeNode
{
    public int val;
    public TreeNode left;
    public TreeNode right;

    public TreeNode(int val = 0, TreeNode left = null, TreeNode right = null)
    {
        this.val = val;
        this.left = left;
        this.right = right;
    }
}

public static class Solution
{
    public static int SumOfRightLeaves(TreeNode root)
    {
        var sum = 0;

        if (root == null) return sum;

        var stack = new Stack<TreeNode>();

        stack.Push(root);

        while (stack.Count() > 0)
        {
            var next = stack.Pop();

            if (next.right != null)
            {
                var rightNext = next.right;
                sum += rightNext.left == null & rightNext.right == null ? rightNext.val : 0;

                stack.Push(rightNext);
            }
            if (next.left != null) stack.Push(next.left);
        }

        return sum;
    }

    public static void Examples()
    {
        var exs = new List<TreeNode>
        {
            new TreeNode { val = 1, left = new TreeNode { val = 3 }, right = new TreeNode { val = 4 } },
            new TreeNode { val = 1, left = new TreeNode { val = 3, right = new TreeNode { val = 5 } }, right = new TreeNode { val = 4, left = new TreeNode { val = 8 }, right = new TreeNode { val = 5 } } }
        };

        foreach (var ex in exs)
        {
            Console.WriteLine($"{SumOfRightLeaves(ex)}");
        }
    }
}