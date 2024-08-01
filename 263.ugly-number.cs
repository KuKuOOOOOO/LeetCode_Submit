/*
 * @lc app=leetcode id=263 lang=csharp
 *
 * [263] Ugly Number
 */

// @lc code=start
public class Solution
{
    public bool IsUgly(int n)
    {
        if (n <= 0)
            return false;
        else if (n == 1)
            return true;
        else
        {
            while (n % 2 == 0)
                n = n / 2;
            while (n % 3 == 0)
                n = n / 3;
            while (n % 5 == 0)
                n = n / 5;
        }
        return n == 1;
    }
}
// @lc code=end

