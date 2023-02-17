/*
 * @lc app=leetcode id=13 lang=csharp
 *
 * [13] Roman to Integer
 */

// @lc code=start
public class Solution
{
    public int RomanToInt(string s)
    {
        int Total = 0;
        Dictionary<char, int> DictRomanToInt = new Dictionary<char, int>()
        {
            { 'I', 1 },
            { 'V', 5 },
            { 'X', 10 },
            { 'L', 50 },
            { 'C', 100 },
            { 'D', 500 },
            { 'M', 1000 }
        };
        s = s.Replace("IV", "IIII").Replace("IX", "VIIII");
        s = s.Replace("XL", "XXXX").Replace("XC", "LXXXX");
        s = s.Replace("CD", "CCCC").Replace("CM", "DCCCC");
        for (int i = 0; i < s.Length; i++)
        {
            if (DictRomanToInt.ContainsKey(s[i]) == true)
            {
                Total += DictRomanToInt[s[i]];
            }
        }
        return Total;
    }
}
// @lc code=end
