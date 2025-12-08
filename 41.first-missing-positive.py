#
# @lc app=leetcode id=41 lang=python3
#
# [41] First Missing Positive
#

# @lc code=start
class Solution:
    def firstMissingPositive(self, nums: List[int]) -> int:
        n = len(nums)

        for i in range(n):
            if nums[i] <= 0 or nums[i] > n:
                nums[i] = n + 1
        
        for i in range(n):
            x = abs(nums[i])

            if 1 <= x <= n:
                idx = x - 1
                if(nums[idx] > 0):
                    nums[idx] = -nums[idx]
        
        for i in range(n):
            if nums[i] > 0:
                return i + 1
            
        return n + 1
# @lc code=end