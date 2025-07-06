#
# @lc app=leetcode id=49 lang=python3
#
# [49] Group Anagrams
#

# @lc code=start
from typing import List
class Solution:
    def groupAnagrams(self, strs: List[str]) -> List[List[str]]:
        n = len(strs)
        anagramsDict = dict()
        result = []
        for word in strs:
            key = ''.join(sorted(word))
            if key in anagramsDict:
                anagramsDict[key].append(word)
            else:
                anagramsDict[key] = [word]
        
        result = [sorted(group) for group in anagramsDict.values()]
        result.sort(key=lambda x: (len(x), x[0]))

        return result

# @lc code=end

