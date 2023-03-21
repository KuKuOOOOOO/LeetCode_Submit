/*
 * @lc app=leetcode id=66 lang=csharp
 *
 * [66] Plus One
 */

// @lc code=start
public class Solution
{
    public int[] PlusOne(int[] digits)
    {
        // int[] ExpansionArray = new int[digits.Length + 1];
        // if (digits[digits.Length - 1] != 9)
        // {
        //     digits[digits.Length - 1] = digits[digits.Length - 1] + 1;
        //     return digits;
        // }
        // digits[digits.Length - 1] = 0;
        // for (int i = 1; i <= digits.Length; i++)
        //     ExpansionArray[ExpansionArray.Length - i] = digits[digits.Length - i];
        // ExpansionArray[ExpansionArray.Length - 2] = ExpansionArray[ExpansionArray.Length - 2] + 1;
        // return ExpansionArray;
        for (int i = digits.Length - 1; i >= 0; i--)
        {
            if (digits[i] != 9)
            {
                digits[i]++;
                return digits;
            }
            else
                digits[i] = 0;
        }
        int[] result = new int[digits.Length + 1];
        result[0] = 1;
        return result;
    }
}
// @lc code=end

