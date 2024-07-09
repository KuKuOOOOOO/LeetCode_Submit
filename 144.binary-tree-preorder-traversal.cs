/*
 * @lc app=leetcode id=144 lang=csharp
 *
 * [144] Binary Tree Preorder Traversal
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
    public IList<int> PreorderTraversal(TreeNode root)
    {
        IList<int> result = new List<int>();
        Stack<TreeNode> stack = new Stack<TreeNode>();

        while(root != null || stack.Count > 0)
        {
            if(root == null)
            {
                root = stack.Peek().right;
                stack.Pop();
            }
            else
            {
                result.Add(root.val);
                stack.Push(root);
                root = root.left;
            }
        }
        return result;
    }
}
// @lc code=end

