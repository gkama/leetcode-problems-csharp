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

    private static IList<int> PostorderTraversalWithStacks(TreeNode root)
    {
        var nodesValues = new List<int>();

        if (root == null) return nodesValues;
        else if (root.left == null && root.right == null)
        {
            nodesValues.Add(root.val);
            return nodesValues;
        }

        var s1 = new Stack<TreeNode>();
        var s2 = new Stack<TreeNode>();
        s1.Push(root);

        while (s1.Count() > 0)
        {
            root = s1.Pop();
            s2.Push(root);

            if (root.left != null)
            {
                s1.Push(root.left);
            }
            if (root.right != null)
            {
                s1.Push(root.right);
            }
        }

        while (s2.Count() > 0)
        {
            root = s2.Pop();
            nodesValues.Add(root.val);
        }

        return nodesValues;
    }
}