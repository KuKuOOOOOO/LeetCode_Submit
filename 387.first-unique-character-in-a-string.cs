/*
 * @lc app=leetcode id=387 lang=csharp
 *
 * [387] First Unique Character in a String
 */

// @lc code=start
public class Solution
{
    public int FirstUniqChar(string s)
    {
        Dictionary<char, int> charCount = new Dictionary<char, int>();
        foreach (char c in s)
        {
            if (charCount.ContainsKey(c))
                charCount[c]++;
            else
                charCount[c] = 1;
        }
        for (int i = 0; i < s.Length; i++)
        {
            if (charCount[s[i]] == 1)
                return i;
        }
        return -1;
    }
}
// @lc code=end

