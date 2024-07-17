/*
 * @lc app=leetcode id=257 lang=csharp
 *
 * [257] Binary Tree Paths
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
    public IList<string> BinaryTreePaths(TreeNode root)
    {
        IList<string> result = new List<string>();
        if (root == null)
            return result;
        DepthFirstSearch(root, string.Empty, ref result);
        return result;
    }
    public void DepthFirstSearch(TreeNode node, string currentPath, ref IList<string> result)
    {
        if (node == null)
            return;
        if (node != null)
            currentPath += node.val.ToString();
        if (node.left == null && node.right == null)
            result.Add(currentPath);
        else
        {
            currentPath += "->";
            DepthFirstSearch(node.left, currentPath, ref result);
            DepthFirstSearch(node.right, currentPath, ref result);
        }
    }
}
// @lc code=end

