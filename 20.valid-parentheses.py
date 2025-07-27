#
# @lc app=leetcode id=20 lang=python3
#
# [20] Valid Parentheses
#

# @lc code=start
class Solution:
    def isValid(self, s: str) -> bool:
        stack = []
        roadMap = {
            "}": "{",
            "]": "[",
            ")": "("
        }

        for char in s:
            if char not in roadMap:
                stack.append(char)
            else:
                if len(stack) == 0:
                    return False
                if stack.pop() != roadMap[char]:
                    return False
        
        return len(stack) == 0
        
        
# @lc code=end

