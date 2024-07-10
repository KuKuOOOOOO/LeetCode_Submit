/*
 * @lc app=leetcode id=543 lang=csharp
 *
 * [543] Diameter of Binary Tree
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
    private int result = 0;
    public int DiameterOfBinaryTree(TreeNode root)
    {
        LongestPathToLeaf(root);
        return result - 1;
    }   
    private int LongestPathToLeaf(TreeNode node)
    {
        if (node == null)
            return 0;

        int leftPath = LongestPathToLeaf(node.left);
        int rightPath = LongestPathToLeaf(node.right);
        result = Math.Max(result, leftPath + 1 + rightPath);
        return Math.Max(leftPath, rightPath) + 1;
    }
}
// @lc code=end

