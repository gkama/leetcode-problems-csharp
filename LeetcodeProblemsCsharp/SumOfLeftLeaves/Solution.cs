// https://leetcode.com/problems/sum-of-left-leaves/
public class TreeNode 
{
    public int val;
    public TreeNode left;
    public TreeNode right;

    public TreeNode(int val=0, TreeNode left=null, TreeNode right=null) 
    {
        this.val = val;
        this.left = left;
        this.right = right;
    }
}

public static class Solution
{
    public static int SumOfLeftLeaves(TreeNode root)
    {
        var sum = 0;

        if (root == null) return sum;

        var stack = new Stack<TreeNode>();

        stack.Push(root);

        while (stack.Count() > 0)
        {
            var next = stack.Pop();

            if (next.right != null) stack.Push(next.right);
            if (next.left != null)
            {
                var leftNext = next.left;
                sum += leftNext.left == null & leftNext.right == null ? leftNext.val : 0;

                stack.Push(leftNext);
            }
        }

        return sum;
    }
}