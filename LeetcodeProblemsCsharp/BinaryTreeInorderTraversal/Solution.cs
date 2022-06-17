// https://leetcode.com/problems/binary-tree-inorder-traversal/
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
        inorder traversal
            first, visit all the nodes in the left subtree
            then the root node
            visit all the nodes in the right subtree
            1
          2   2
         3 4 3 4
    */
    public static IList<int> InorderTraversal(TreeNode root)
    {
        var nodesValues = new List<int>();

        if (root == null) return nodesValues;

        var stack = new Stack<TreeNode>();
        var next = root;

        while (stack.Count() > 0 || next != null)
        {
            if (next != null)
            {
                stack.Push(next);
                next = next.left;
            }
            else
            {
                next = stack.Pop();
                nodesValues.Add(next.val);
                next = next.right;
            }
        }

        return nodesValues;
    }
}