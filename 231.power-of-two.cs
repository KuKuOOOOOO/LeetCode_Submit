/*
 * @lc app=leetcode id=231 lang=csharp
 *
 * [231] Power of Two
 */

// @lc code=start
public class Solution
{
    public bool IsPowerOfTwo(int n)
    {
        if (n < 0)
            return false;

        string binary = Convert.ToString(n, 2);
        int onesCount = binary.Count(c => c == '1');
        return onesCount == 1;
    }
}
// @lc code=end

