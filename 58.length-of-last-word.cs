/*
 * @lc app=leetcode id=58 lang=csharp
 *
 * [58] Length of Last Word
 */

// @lc code=start
public class Solution
{
    public int LengthOfLastWord(string s)
    {
        int count = 0;
        bool FoundWord = false;
        for (int i = s.Length - 1; i >= 0; i--)
        {
            if (s[i] != ' ')
            {
                count++;
                FoundWord = true;
            }
            else if (FoundWord)
                break;
        }
        return count;

    }
}
// @lc code=end

