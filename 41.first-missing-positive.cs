/*
 * @lc app=leetcode id=41 lang=csharp
 *
 * [41] First Missing Positive
 */

// @lc code=start
using System;

public class Solution
{
    public int FirstMissingPositive(int[] nums)
    {
        int numsLength = nums.Length;

        for (int i = 0; i < numsLength; i++)
        {
            if (nums[i] <= 0 || nums[i] > numsLength)
                nums[i] = numsLength + 1;
        }

        for (int i = 0; i < numsLength; i++)
        {
            int positiveNum = Math.Abs(nums[i]);

            if (positiveNum >= 1 && positiveNum <= numsLength)
            {
                int index = positiveNum - 1;

                if (nums[index] > 0)
                    nums[index] = -1 * nums[index];     // Mark integer in this list
            }
        }

        for (int i = 0; i < numsLength; i++)
        {
            if (nums[i] > 0)
                return i + 1;
        }

        return numsLength + 1;
    }
}
// @lc code=end

