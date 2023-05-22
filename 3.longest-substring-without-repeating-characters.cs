/*
 * @lc app=leetcode id=3 lang=csharp
 *
 * [3] Longest Substring Without Repeating Characters
 */

// @lc code=start
public class Solution
{
    public int LengthOfLongestSubstring(string s)
    {
        int maxLen = 0;
        int left = 0;
        int right = 0;
        HashSet<char> uniqueChars = new HashSet<char>();

        while (right < s.Length)
        {
            if (!uniqueChars.Contains(s[right]))
            {
                uniqueChars.Add(s[right]);
                maxLen = Math.Max(maxLen, right - left + 1);
                right++;
            }
            else
            {
                uniqueChars.Remove(s[left]);
                left++;
            }
        }
        return maxLen;

    }
}
// @lc code=end

