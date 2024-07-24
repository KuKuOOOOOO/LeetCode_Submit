/*
 * @lc app=leetcode id=242 lang=csharp
 *
 * [242] Valid Anagram
 */

// @lc code=start
public class Solution
{
    public bool IsAnagram(string s, string t)
    {
        if (s.Length != t.Length)
            return false;
        Dictionary<char, int> pair = new Dictionary<char, int>();
        foreach (char c in s)
        {
            if (pair.ContainsKey(c))
                pair[c]++;
            else
                pair[c] = 1;
        }
        foreach (char c in t)
        {
            if (pair.ContainsKey(c))
                pair[c]--;
            else
                return false;
        }
        foreach (var k in pair)
        {
            if (k.Value != 0)
                return false;
        }
        return true;

    }
}
// @lc code=end

