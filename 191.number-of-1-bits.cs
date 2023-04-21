/*
 * @lc app=leetcode id=191 lang=csharp
 *
 * [191] Number of 1 Bits
 */

// @lc code=start
public class Solution
{
    public int HammingWeight(uint n)
    {
        int result = 0;
        while (n != 0)
        {
            result++;
            n &= (n - 1);
        }
        return result;
    }
}
// @lc code=end

