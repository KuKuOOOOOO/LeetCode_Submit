/*
 * @lc app=leetcode id=338 lang=csharp
 *
 * [338] Counting Bits
 */

// @lc code=start
public class Solution {
    public int[] CountBits(int n) 
    {
        int [] result = new int[n + 1];
        for(int i = 0; i <= n; i++)
        {
            result[i] = result[i >> 1] + (i & 1);   
        }
        return result;
    }
}
// @lc code=end

