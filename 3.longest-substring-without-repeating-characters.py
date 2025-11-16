#
# @lc app=leetcode id=3 lang=python3
#
# [3] Longest Substring Without Repeating Characters
#

# @lc code=start
class Solution:
    def lengthOfLongestSubstring(self, s: str) -> int:
        right = 0
        left = 0
        maxLen = 0
        uniqueChars = set()

        while right < len(s):
            if s[right] in uniqueChars:
                uniqueChars.remove(s[left])
                left = left + 1
            else:
                uniqueChars.add(s[right])
                maxLen = max(maxLen, right - left + 1)
                right = right + 1
        
        return maxLen

# @lc code=end

