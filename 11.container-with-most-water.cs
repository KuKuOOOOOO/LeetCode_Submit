/*
 * @lc app=leetcode id=11 lang=csharp
 *
 * [11] Container With Most Water
 */

// @lc code=start
public class Solution
{
    public int MaxArea(int[] height)
    {
        int left = 0;
        int right = height.Length - 1;
        int maxArea = 0;

        while (left < right)
        {
            int width = right - left;
            int minHight = Math.Min(height[left], height[right]);
            int currentArea = width * minHight;

            maxArea = Math.Max(maxArea, currentArea);

            if (height[left] < height[right])
                left++;
            else
                right--;
        }

        return maxArea;

    }
}
// @lc code=end

