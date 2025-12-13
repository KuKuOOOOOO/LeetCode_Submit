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

        // Step 1: 把 <= 0 & > n的數字更改成n + 1
        for (int i = 0; i < numsLength; i++)
        {
            if (nums[i] <= 0 || nums[i] > numsLength)
                nums[i] = numsLength + 1;
        }

        // Step 2: 使用Index標記出現過的 1..n
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

        // Step 3: 找第一個仍然為正數的位置
        for (int i = 0; i < numsLength; i++)
        {
            if (nums[i] > 0)
                return i + 1;
        }

        return numsLength + 1;
    }
}
// @lc code=end

