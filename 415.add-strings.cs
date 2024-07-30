/*
 * @lc app=leetcode id=415 lang=csharp
 *
 * [415] Add Strings
 */

// @lc code=start
public class Solution
{
    public string AddStrings(string num1, string num2)
    {
        List<int> result = new List<int>();

        int i = num1.Length - 1;
        int j = num2.Length - 1;
        int carry = 0;

        while (i >= 0 || j >= 0 || carry != 0)
        {
            int digit1 = i >= 0 ? num1[i] - '0' : 0;
            int digit2 = j >= 0 ? num2[j] - '0' : 0;

            int total = digit1 + digit2 + carry;
            result.Add(total % 10);
            carry = total / 10;

            i--;
            j--;
        }

        result.Reverse();
        return string.Join("", result);
    }
}
// @lc code=end

