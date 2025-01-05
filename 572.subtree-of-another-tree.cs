/*
 * @lc app=leetcode id=572 lang=csharp
 *
 * [572] Subtree of Another Tree
 */

// @lc code=start
/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int val=0, TreeNode left=null, TreeNode right=null) {
 *         this.val = val;
 *         this.left = left;
 *         this.right = right;
 *     }
 * }
 */
public class Solution
{
    public bool IsSubtree(TreeNode root, TreeNode subRoot)
    {
        if (subRoot == null)
            return true;
        if (root == null)
            return false;

        return IsSameTree(root, subRoot) || IsSubtree(root.left, subRoot) || IsSubtree(root.right, subRoot);
    }

    private bool IsSameTree(TreeNode subTreeByRoot, TreeNode subRoot)
    {
        if (subTreeByRoot == null && subRoot == null)
            return true;
        if (subTreeByRoot == null || subRoot == null || subTreeByRoot.val != subRoot.val)
            return false;

        return IsSameTree(subTreeByRoot.left, subRoot.left) && IsSameTree(subTreeByRoot.right, subRoot.right);
    }
}
// @lc code=end

