// https://leetcode.com/problems/validate-binary-search-tree/
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
    public static bool IsValidBST(TreeNode root)
    {
        return DFS(root, long.MinValue, long.MaxValue);
    }

    private static bool DFS(TreeNode root, long min, long max)
    {
        if (root == null) return true;
        if (min < root.val && root.val < max)
        {
            var leftResult = DFS(root.left, min, root.val);
            var rightResult = DFS(root.right, root.val, max);

            if (leftResult && rightResult)
            {
                return true;
            }
        }

        return false;
    }

    #region Solution 2
    private static int? prev = null;

    public static bool IsValidBST2(TreeNode root)
    {
        return DFS2(root);
    }

    private static bool DFS2(TreeNode node)
    {
        if (node == null)
            return true;

        if (!DFS2(node.left))
            return false;

        if (prev != null && node.val <= prev)
            return false;

        prev = node.val;

        return DFS2(node.right);
    }
    #endregion

    #region My attempted solution
    /*
                3
            1       5
          0   2    4  6
    */
    public static bool IsValidBST3(TreeNode root)
    {
        if (root == null) return false;
        if (root.left == null && root.right == null) return true;

        if (IsValidTreeNode(root) == false) return false;

        // Now do it for left subtree
        // Now do it for right subtree
        var leftSubtree = IsValidBSTInternal(root.val, root.left, inLeftSubtree: true);
        var rightSubtree = IsValidBSTInternal(root.val, root.right, inLeftSubtree: false);

        return leftSubtree && rightSubtree;
    }

    private static bool IsValidBSTInternal(int rootVal, TreeNode root, bool inLeftSubtree)
    {
        if (root == null) return true;

        var rootValues = new List<int>();
        rootValues.Add(rootVal);
        var queue = new Queue<TreeNode>();
        queue.Enqueue(root);

        while (queue.Count() > 0)
        {
            var next = queue.Dequeue();

            foreach (var rv in rootValues)
            {
                if (inLeftSubtree && next.val > rv) return false;
                if (!inLeftSubtree && next.val < rv) return false;
            }

            if (IsValidTreeNode(root) == false) return false;

            if (next.left != null && next.right != null) rootValues.Add(next.val);

            if (next.left != null) queue.Enqueue(next.left);
            if (next.right != null) queue.Enqueue(next.right);
        }

        return true;
    }

    private static bool IsValidTreeNode(TreeNode root)
    {
        if (root == null) return true;

        if (root.left != null && root.right == null && root.val > root.left.val) return true;
        if (root.left == null && root.right != null && root.val < root.right.val) return true;
        if (root.val > root.left?.val && root.val < root.right?.val) return true;
        if (root.left == null && root.right == null) return true;
        else return false;
    }
    #endregion
}