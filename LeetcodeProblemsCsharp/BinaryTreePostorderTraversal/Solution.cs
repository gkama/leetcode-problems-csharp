// https://leetcode.com/problems/binary-tree-postorder-traversal/
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
        visit the left subtree
        visit the right subtree
        visit the node;
    */
    public static IList<int> PostorderTraversal(TreeNode root)
    {
        var nodesValues = new List<int>();

        if (root == null) return nodesValues;
        else if (root.left == null && root.right == null)
        {
            nodesValues.Add(root.val);
            return nodesValues;
        }

        AddPostorder(root);

        void AddPostorder(TreeNode node)
        {
            if (node == null)
            {
                return;
            }

            AddPostorder(node.left);
            AddPostorder(node.right);

            nodesValues.Add(node.val);
        }

        return nodesValues;
    }
}