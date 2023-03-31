/*
 * @lc app=leetcode id=70 lang=csharp
 *
 * [70] Climbing Stairs
 */

// @lc code=start
public class Solution
{
    public int ClimbStairs(int n)
    {
        if (n <= 2)
            return n;
        int PreStep1 = 2;
        int PreStep2 = 1;
        int Current = 0;
        for (int i = 3; i <= n; i++)
        {
            Current = PreStep1 + PreStep2;
            PreStep2 = PreStep1;
            PreStep1 = Current;
        }
        return Current;
    }
}
// @lc code=end

