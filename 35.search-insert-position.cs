/*
 * @lc app=leetcode id=35 lang=csharp
 *
 * [35] Search Insert Position
 */

// @lc code=start
public class Solution
{
    public int SearchInsert(int[] nums, int target)
    {
        int Start = 0;
        int End = nums.Length - 1;
        while (Start <= End)
        {
            int Center = (Start + End) / 2;

            if(nums[Center] == target)
                return Center;
            else if(nums[Center] < target)
                Start = Center + 1;
            else
                End = Center - 1;
        }
        return Start;
    }
}
// @lc code=end

