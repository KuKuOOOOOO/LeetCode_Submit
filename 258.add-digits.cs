/*
 * @lc app=leetcode id=258 lang=csharp
 *
 * [258] Add Digits
 */

// @lc code=start
public class Solution
{
    public int AddDigits(int num)
    {
        int calculateNumber = num;
        
        #region Method 1
        while (calculateNumber / 10 != 0)
        {
            int decimalNumber = calculateNumber / 10;
            int digitNumber = calculateNumber % 10;
            calculateNumber = decimalNumber + digitNumber;
        }
        #endregion

        #region  Method 2
        calculateNumber = 1 + (calculateNumber - 1) % 9;
        #endregion

        return calculateNumber;
    }
}
// @lc code=end

