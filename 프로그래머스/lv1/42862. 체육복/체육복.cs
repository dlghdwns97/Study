using System;
using System.Collections.Generic;
using System.Linq;

public class Solution {
    public int solution(int n, int[] lost, int[] reserve) {
        int answer = 0;
        int temp = 0;
        Array.Sort(lost);
        List<int> lostList = lost.ToList();
        List<int> reserveList = reserve.ToList();
        
        for (int i = 0; i < lost.Length; i++)
        {
            bool isMe = reserveList.Exists(x => x == lost[i]);
            if (isMe == true)
            {
                lostList.Remove(lost[i]);
                reserveList.Remove(lost[i]);
                temp++;
            }
        }
        
        for (int i = 0; i < lostList.Count; i++)
        {
            bool isSmall = reserveList.Exists(x => x == lostList[i] - 1);
            if (isSmall == true)
            {
                reserveList.Remove(lostList[i] - 1);
                temp++;
            }
            else
            {
                bool isBig = reserveList.Exists(y => y == lostList[i] + 1);
                if (isBig == true)
                {
                    reserveList.Remove(lostList[i] + 1);
                    temp++;
                }
            }
        }
        answer = n - lost.Length + temp;
        return answer;
    }
}