#
# @lc app=leetcode id=23 lang=python3
#
# [23] Merge k Sorted Lists
#
from typing import Optional
import heapq
# @lc code=start
# Definition for singly-linked list.
class ListNode:
    def __init__(self, val=0, next=None):
        self.val = val
        self.next = next
class Solution:
    def mergeKLists(self, lists: list[Optional[ListNode]]) -> Optional[ListNode]:
        heap = [] 

        for index, node in enumerate(lists):
            if node:
                heapq.heappush(heap, (node.val, index, node))

        dummy = ListNode(0)
        current = dummy
        
        while heap:
            val, index, node = heapq.heappop(heap)
            
            current.next = node
            current = current.next

            if node.next:
                heapq.heappush(heap, (node.next.val, index, node.next))

        return dummy.next

                    
# @lc code=end

