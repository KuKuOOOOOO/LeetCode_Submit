/*
 * @lc app=leetcode id=50 lang=csharp
 *
 * [50] Pow(x, n)
 */

// @lc code=start
public class Solution
{
    public double MyPow(double x, int n)
    {
        if (n == 0)
            return 1.0;
        if (n == int.MinValue)
        {
            x = x * x;
            n = n / 2;
        }
        if (n < 0)
        {
            x = 1.0 / x;
            n = -n;
        }
        double half = MyPow(x, n / 2);
        double result = half * half;
        if (n % 2 == 1)
            result *= x;
        return result;

    }
}
// @lc code=end

