/*
 * @lc app=leetcode id=20 lang=csharp
 *
 * [20] Valid Parentheses
 */

// @lc code=start
public class Solution
{
    public bool IsValid(string s)
    {
        Stack<char> Valids = new Stack<char>();
        Dictionary<char, char> Roadmap = new Dictionary<char, char>
        {
            { '}', '{' },
            { ']', '[' },
            { ')', '(' },
        };
        for (int i = 0; i < s.Length; i++)
        {
            if (s[i] == '{' || s[i] == '[' || s[i] == '(')
                Valids.Push(s[i]);
            else
            {
                if (Valids.Count == 0)
                    return false;
                if (Valids.Pop() != Roadmap[s[i]])
                    return false;
            }
        }
        return Valids.Count == 0;
    }
}
// @lc code=end
