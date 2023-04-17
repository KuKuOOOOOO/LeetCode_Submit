/*
 * @lc app=leetcode id=118 lang=csharp
 *
 * [118] Pascal's Triangle
 */

// @lc code=start
public class Solution
{
    public IList<IList<int>> Generate(int numRows)
    {
        IList<IList<int>> result = new List<IList<int>>();

        for (int i = 0; i < numRows; i++)
        {
            IList<int> row = new List<int>();

            for (int j = 0; j <= i; j++)
            {
                if (j == 0 || j == i)
                    row.Add(1);
                else
                    row.Add(result[i - 1][j - 1] + result[i - 1][j]);
            }
            result.Add(row);
        }
        return result;
    }
}
// @lc code=end

