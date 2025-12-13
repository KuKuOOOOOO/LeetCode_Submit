#
# @lc app=leetcode id=704 lang=python3
#
# [704] Binary Search
#

# @lc code=start
class Solution:
    def search(self, nums: List[int], target: int) -> int:
        leftIndex = 0
        rightIndex = len(nums) - 1

        while leftIndex <= rightIndex:
            
            midIndex = (leftIndex + rightIndex) // 2

            if nums[midIndex] == target:
                return midIndex
            elif nums[midIndex] < target:
                leftIndex = leftIndex + 1
            else:
                rightIndex = rightIndex - 1
        
        return -1
# @lc code=end

