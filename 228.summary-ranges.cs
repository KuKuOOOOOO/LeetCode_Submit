/*
 * @lc app=leetcode id=228 lang=csharp
 *
 * [228] Summary Ranges
 */

// @lc code=start
public class Solution
{
    public IList<string> SummaryRanges(int[] nums)
    {
        int i = 0;
        IList<string> result = new List<string>();
        while (i < nums.Length)
        {
            int start = nums[i];
            while (i < (nums.Length - 1) && (nums[i] + 1) == nums[i + 1])
            {
                i++;
            }

            string startStr = start.ToString();
            string endStr = nums[i].ToString();

            if (start != nums[i])
                result.Add($@"{startStr}->{endStr}");
            else
                result.Add($@"{startStr}");
            i++;
        }
        return result;
    }
}
// @lc code=end

