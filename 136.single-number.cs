/*
 * @lc app=leetcode id=136 lang=csharp
 *
 * [136] Single Number
 */

// @lc code=start
public class Solution
{
    public int SingleNumber(int[] nums)
    {
        int result = 0;
        foreach (int num in nums)
            result ^= num;
        return result;
    }
}
// @lc code=end

