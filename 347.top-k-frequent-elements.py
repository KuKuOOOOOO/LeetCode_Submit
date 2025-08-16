#
# @lc app=leetcode id=347 lang=python3
#
# [347] Top K Frequent Elements
#

# @lc code=start
class Solution:
    def topKFrequent(self, nums: list[int], k: int) -> list[int]:
        count_dict = {}
        result = []

        for num in nums:
            if num in count_dict:
                count_dict[num] += 1
            else:
                count_dict[num] = 1
        
        sorted_items = sorted(count_dict.items(), key=lambda x:x[1], reverse=True)

        for rank, (number, occurrence) in enumerate(sorted_items):
            if rank == k:
                break
            result.append(number)

        return result
        
# @lc code=end

