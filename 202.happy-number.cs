/*
 * @lc app=leetcode id=202 lang=csharp
 *
 * [202] Happy Number
 */

// @lc code=start
public class Solution {
    public bool IsHappy(int n) 
    {
        HashSet<int> set = new HashSet<int>();
        while(n != 1)
        {
            int sum = 0;
            while(n > 0)
            {
                int digit = n % 10;
                sum += digit * digit;
                n /= 10;
            }
            n = sum;
            if(set.Contains(n))
                return false;
            else
                set.Add(n);
        }
        return true;
    }
}
// @lc code=end

