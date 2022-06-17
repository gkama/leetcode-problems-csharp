// https://leetcode.com/problems/same-tree/
public class TreeNode {
    public int val;
    public TreeNode left;
    public TreeNode right;
    public TreeNode(int val=0, TreeNode left=null, TreeNode right=null) {
        this.val = val;
        this.left = left;
        this.right = right;
    }
}

public static class Solution
{
    /*
    Alg
        create 2 stacks
            populate both with each tree respectively
            DFS approach
        then check if they the have the same size
            if not, return false
        if so, then iterate through one and pop from both
        check if they have the same value
        if everything passes return true
    */
    public static bool IsSameTree(TreeNode p, TreeNode q)
    {
        if (p == null && q == null) return true;
        if (p == null && q != null) return false;
        if (p != null && q == null) return false;

        var s1 = new Stack<TreeNode>();
        var s2 = new Stack<TreeNode>();

        s1.Push(p);
        s2.Push(q);

        while (s1.Count() > 0)
        {
            var nextS1 = s1.Pop();
            var nextS2 = s2.Pop();

            Console.WriteLine(nextS1.val);
            Console.WriteLine(nextS2.val);

            if (nextS1.val != nextS2.val) return false;

            if (nextS1.right == null && nextS2.right == null)
            {
                // Do nothing
            }
            else if (nextS1.right != null && nextS2.right != null)
            {
                s1.Push(nextS1.right);
                s2.Push(nextS2.right);
            }
            else
            {
                return false;
            }

            if (nextS1.left == null && nextS2.left == null)
            {
                // Do nothing
            }
            else if (nextS1.left != null && nextS2.left != null)
            {
                s1.Push(nextS1.left);
                s2.Push(nextS2.left);
            }
            else
            {
                return false;
            }
        }

        return true;
    }
}