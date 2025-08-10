#
# @lc app=leetcode id=763 lang=python3
#
# [763] Partition Labels
#

# @lc code=start
class Solution:
    def partitionLabels(self, s: str) -> list[int]:
        
        lastIndex = {}
        for i, c in enumerate(s):
            lastIndex[c] = i

        result = []
        startPoint = 0
        endPoint = 0
        for i, c in enumerate(s):
            endPoint = max(endPoint, lastIndex[c])

            if i == endPoint:
                result.append(endPoint - startPoint + 1)
                startPoint = i + 1

        return result
# @lc code=end

