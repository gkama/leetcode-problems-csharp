// https://leetcode.com/problems/convert-sorted-array-to-binary-search-tree/
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
        since they're sorted the middle is the root
        once you have root, create left and right subtree
        to the left of mid is the lower than root.val
        to the right of the mid is greater than root.val
    */
    public static TreeNode SortedArrayToBST(int[] nums)
    {
        if (nums == null || nums.Length == 0)
        {
            return null;
        }

        return BuildTree(nums, 0, nums.Length - 1);
    }

    private static TreeNode BuildTree(int[] nums, int i, int j)
    {
        if (j < i)
        {
            return null;
        }

        var mid = j + (i - j) / 2;
        TreeNode node = new TreeNode(nums[mid]);

        node.left = BuildTree(nums, i, mid - 1);
        node.right = BuildTree(nums, mid + 1, j);

        return node;
    }
}