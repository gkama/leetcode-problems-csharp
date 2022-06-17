// https://leetcode.com/problems/binary-tree-preorder-traversal/
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
        preorder
        visit the root
        visit the left subtree
        visit the right subtree
        this is a regular DFS
    */
    public static IList<int> PreorderTraversal(TreeNode root)
    {
        var visitedNodesValues = new List<int>();

        if (root == null) return visitedNodesValues;
        else if (root.left == null && root.right == null)
        {
            visitedNodesValues.Add(root.val);
            return visitedNodesValues;
        }

        var stack = new Stack<TreeNode>();

        stack.Push(root);

        while (stack.Count() > 0)
        {
            var next = stack.Pop();

            visitedNodesValues.Add(next.val);

            if (next.right != null) stack.Push(next.right);
            if (next.left != null) stack.Push(next.left);
        }

        return visitedNodesValues;
    }
}