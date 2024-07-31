/*
 * @lc app=leetcode id=125 lang=csharp
 *
 * [125] Valid Palindrome
 */

// @lc code=start
public class Solution
{
    public bool IsPalindrome(string s)
    {
        string alphanumericStr = string.Empty;
        string compareStr = string.Empty;
        for (int i = 0; i < s.Length; i++)
        {
            if (s[i] >= 'A' && s[i] <= 'Z')
                alphanumericStr += (char)(s[i] + ('a' - 'A'));
            else if ((s[i] >= 'a' && s[i] <= 'z') ||
                     (s[i] >= '0' && s[i] <= '9'))
                alphanumericStr += s[i];
        }
        compareStr = new string(alphanumericStr.Reverse().ToArray());
        return alphanumericStr == compareStr;
    }
}
// @lc code=end

