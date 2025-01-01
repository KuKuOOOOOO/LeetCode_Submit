/*
 * @lc app=leetcode id=217 lang=csharp
 *
 * [217] Contains Duplicate
 */

// @lc code=start
public class Solution
{
    public bool ContainsDuplicate(int[] nums)
    {
        List<int> seen = new List<int>();

        foreach(int num in nums)
        {
            if(seen.Contains(num))
                return true;
            
            seen.Add(num);
        }

        return false;
    }
}
// @lc code=end

