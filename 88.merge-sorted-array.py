#
# @lc app=leetcode id=88 lang=python3
#
# [88] Merge Sorted Array
#

# @lc code=start
class Solution:
    def merge(self, nums1: list[int], m: int, nums2: list[int], n: int) -> None:
        """
        Do not return anything, modify nums1 in-place instead.
        """
        nums1Count = m - 1
        nums2Count = n - 1
        currentPoint = m + n - 1

        while nums1Count >= 0 and nums2Count >= 0:
            if nums1[nums1Count] >= nums2[nums2Count]:
                nums1[currentPoint] = nums1[nums1Count]
                nums1Count -= 1
            else:
                nums1[currentPoint] = nums2[nums2Count]
                nums2Count -= 1
            currentPoint -= 1
        
        while nums2Count >= 0:
            nums1[currentPoint] = nums2[nums2Count]
            nums2Count -= 1
            currentPoint -= 1
        
# @lc code=end

