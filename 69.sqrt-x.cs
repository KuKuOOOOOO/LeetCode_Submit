/*
 * @lc app=leetcode id=69 lang=csharp
 *
 * [69] Sqrt(x)
 */

// @lc code=start
public class Solution
{
    public int MySqrt(int x)
    {
        if (x < 2)
            return x;
        int left = 1;
        int right = x;
        while (left <= right)
        {
            int mid = left + (right - left) / 2;
            if (mid == x / mid)
                return mid;
            else if (mid > (x / mid))
                right = mid - 1;
            else
                left = mid + 1;
        }
        return right;
    }
}
// @lc code=end

