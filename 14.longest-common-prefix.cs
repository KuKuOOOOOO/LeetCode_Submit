/*
 * @lc app=leetcode id=14 lang=csharp
 *
 * [14] Longest Common Prefix
 */

// @lc code=start
public class Solution
{
    public string LongestCommonPrefix(string[] strs)
    {
        if (strs == null || strs.Length == 0)
            return "";
        string Pre = strs[0];
        int i = 1;
        while (i < strs.Length)
        {
            while (strs[i].IndexOf(Pre) != 0)
                Pre = Pre.Substring(0, Pre.Length - 1);
            i++;
        }
        return Pre;
    }
}
// @lc code=end
