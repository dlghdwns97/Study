using System;
using System.Collections.Generic;
using System.Linq;

public class Solution {
    public int solution(int k, int[] tangerine) {
        int answer = 0;
        Dictionary<int, int> tangDic = new Dictionary<int, int>();
        int count = 0;
        
        for (int i = 0; i < tangerine.Length; i++)
        {
            if (tangDic.ContainsKey(tangerine[i]))
            {
                tangDic[tangerine[i]]++;
            }
            else
            {
                tangDic.Add(tangerine[i], 1);
            }
        }

        List<int> tangList = new List<int>(tangDic.Values);
        List<int> sortedTangList = tangList.OrderByDescending(i => i).ToList();
        
        for (int i = 0; i < sortedTangList.Count; i++)
        {
            count += sortedTangList[i];
            if (count >= k)
            {
                answer = i + 1;
                break;
            }
        }
        
        return answer;
    }
}