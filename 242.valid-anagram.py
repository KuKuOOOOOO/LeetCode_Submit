#
# @lc app=leetcode id=242 lang=python3
#
# [242] Valid Anagram
#

# @lc code=start
class Solution:
    def isAnagram(self, s: str, t: str) -> bool:
        
        if len(s) != len(t):
            return False
        
        pair = {}

        for char in s:
            pair[char] = pair.get(char, 0) + 1

        for char in t:
            if pair.get(char, 0) == 0:
                return False
            else:
                pair[char] -= 1
        
        return True
                
# @lc code=end

