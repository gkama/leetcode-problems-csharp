// https://leetcode.com/problems/lowest-common-ancestor-of-a-binary-search-tree/
public class TreeNode {
    public int val;
    public TreeNode left;
    public TreeNode right;
    public TreeNode(int x) { val = x; }
}


public static class Solution
{
    /*
    Alg
        if p or q are ancestors of the other retun the other one
            for example, if p is an ancestor of q (or a parent node), then return p
                         if q is an ancestor of p (or a parent node), then return q
        DFS
    */
    public static TreeNode LowestCommonAncestor(TreeNode root, TreeNode p, TreeNode q)
    {
        if (root == null) return null;
        if (p == null || q == null) return null;

        if (root.left == p && root.right == q) return root;
        if (p.left == q || p.right == q) return p;
        if (q.left == p || q.right == p) return q;

        return LowestCommonAncestorNonRecursive(root, p, q);
    }

    private static TreeNode LowestCommonAncestorNonRecursive(TreeNode root, TreeNode p, TreeNode q)
    {
        while (root != null)
        {
            if (root.val > p.val && root.val > q.val)
            {
                root = root.left;
            }
            else if (root.val < p.val && root.val < q.val)
            {
                root = root.right;
            }

            else
            {
                break;
            }
        }

        return root;
    }
}