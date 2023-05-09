/*
 * @lc app=leetcode id=326 lang=csharp
 *
 * [326] Power of Three
 */

// @lc code=start
public class Solution
{
    public bool IsPowerOfThree(int n)
    {
        if (n > 0)
        {
            double log = Math.Log10(n) / Math.Log10(3);
            return log == Math.Floor(log);
        }
        return false;

    }
}
// @lc code=end

