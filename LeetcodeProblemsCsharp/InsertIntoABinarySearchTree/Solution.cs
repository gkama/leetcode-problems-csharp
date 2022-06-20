// https://leetcode.com/problems/insert-into-a-binary-search-tree/
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
        recursively insert
        if root is null return new TreeNode(val)
        root.left = call again with root.left and val
        root.right = call again with root.right and val
    */
    public static TreeNode InsertIntoBST(TreeNode root, int val)
    {
        if (root == null)
        {
            return new TreeNode(val);
        }

        return InsertRecursive(root, val);
    }

    private static TreeNode InsertRecursive(TreeNode root, int val)
    {
        if (root == null)
        {
            return new TreeNode(val);
        }

        if (root.val > val)
        {
            // Go to the left subtree
            root.left = InsertRecursive(root.left, val);
        }
        else
        {
            // Go to the right subtree
            root.right = InsertRecursive(root.right, val);
        }

        return root;
    }
}