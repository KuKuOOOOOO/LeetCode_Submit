/*
 * @lc app=leetcode id=704 lang=csharp
 *
 * [704] Binary Search
 */

// @lc code=start
public class Solution
{
    public int Search(int[] nums, int target)
    {
        int leftIndex = 0;
        int rigthIndex = nums.Length - 1;

        while (leftIndex <= rigthIndex)
        {
            int midIndex = (leftIndex + rigthIndex) / 2;

            if (nums[midIndex] == target)
                return midIndex;
            else if (nums[midIndex] < target)
                leftIndex++;
            else
                rigthIndex--;
        }

        return -1;

    }
}
// @lc code=end

