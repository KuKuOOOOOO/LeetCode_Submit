#
# @lc app=leetcode id=42 lang=python3
#
# [42] Trapping Rain Water
#

# @lc code=start
from typing import List
class Solution:
    def trap(self, height: List[int]) -> int:
        totalTrapQty = 0
        findleftMaxPointer = 0
        findrightMaxPointer = len(height) - 1
        leftMax = 0
        rightMax = 0

        while findleftMaxPointer < findrightMaxPointer:
            
            if height[findleftMaxPointer] < height[findrightMaxPointer]:
                if height[findleftMaxPointer] > leftMax:
                    leftMax = height[findleftMaxPointer]
                else:
                    totalTrapQty += leftMax - height[findleftMaxPointer]
                findleftMaxPointer += 1
            else:
                if height[findrightMaxPointer] > rightMax:
                    rightMax = height[findrightMaxPointer]
                else:
                    totalTrapQty += rightMax - height[findrightMaxPointer]
                findrightMaxPointer -= 1

        return totalTrapQty
# @lc code=end

