/*
 * @lc app=leetcode id=344 lang=csharp
 *
 * [344] Reverse String
 */

// @lc code=start
public class Solution
{
    public void ReverseString(char[] s)
    {
        int Left = 0;
        int Right = s.Length - 1;

        while (Left < Right)
        {
            char temp = s[Left];
            s[Left] = s[Right];
            s[Right] = temp;
            Left++;
            Right--;
        }
    }
}
// @lc code=end

