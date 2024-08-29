/*
 * @lc app=leetcode id=283 lang=csharp
 *
 * [283] Move Zeroes
 */

// @lc code=start
public class Solution
{
    public void MoveZeroes(int[] nums)
    {
        int n = nums.Length;
        int nonZeroIndex = 0;

        for (int i = 0; i < n; i++)
        {
            if (nums[i] != 0)
            {
                nums[nonZeroIndex] = nums[i];
                nonZeroIndex++;
            }
        }

        for (int i = nonZeroIndex; i < n; i++)
            nums[i] = 0;
    }
}
// @lc code=end

