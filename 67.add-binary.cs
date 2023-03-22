/*
 * @lc app=leetcode id=67 lang=csharp
 *
 * [67] Add Binary
 */

// @lc code=start
public class Solution
{
    public string AddBinary(string a, string b)
    {
        int Carry = 0;
        int DigitsA = a.Length - 1;
        int DigitsB = b.Length - 1;
        string result = "";

        while (DigitsA >= 0 || DigitsB >= 0 || Carry > 0)
        {
            int sum = Carry;

            if (DigitsA >= 0)
            {
                sum += a[DigitsA] - '0';
                DigitsA--;
            }
            if (DigitsB >= 0)
            {
                sum += b[DigitsB] - '0';
                DigitsB--;
            }
            result = (sum % 2).ToString() + result;
            Carry = sum / 2;
        }

        return result;
    }
}
// @lc code=end

