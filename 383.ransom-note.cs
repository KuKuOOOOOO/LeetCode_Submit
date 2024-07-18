/*
 * @lc app=leetcode id=383 lang=csharp
 *
 * [383] Ransom Note
 */

// @lc code=start
public class Solution
{
    public bool CanConstruct(string ransomNote, string magazine)
    {
        if (string.IsNullOrEmpty(ransomNote))
            return true;
        if (string.IsNullOrEmpty(magazine))
            return false;
        List<char> magazineList = magazine.ToList();
        foreach (char c in ransomNote)
        {
            int index = magazineList.IndexOf(c);
            if (index == -1)
                return false;
            magazineList.RemoveAt(index);
        }
        return true;
    }
}
// @lc code=end

