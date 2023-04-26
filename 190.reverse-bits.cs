/*
 * @lc app=leetcode id=190 lang=csharp
 *
 * [190] Reverse Bits
 */

// @lc code=start
public class Solution
{
    public uint reverseBits(uint n)
    {
        uint result = 0;
        for (int i = 0; i < 32; i++)
        {
            result <<= 1;
            result |= n & 1;
            n >>= 1;
        }
        return result;
    }
}
// @lc code=end
