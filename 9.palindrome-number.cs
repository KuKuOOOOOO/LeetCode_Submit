/*
 * @lc app=leetcode id=9 lang=csharp
 *
 * [9] Palindrome Number
 */

// @lc code=start
public class Solution
{
    public bool IsPalindrome(int x)
    {
        List<char> ListCompareParam = new List<char>();
        for (int i = 1; i <= x.ToString().Length; i++)
        {
            ListCompareParam.Add(x.ToString()[x.ToString().Length - i]);
        }
        var CompareParam = String.Join("", ListCompareParam.ToArray());
        if (CompareParam != null)
        {
            if (x.ToString() == CompareParam)
                return true;
            else
                return false;
        }
        else
            return false;
    }
}
// @lc code=end
