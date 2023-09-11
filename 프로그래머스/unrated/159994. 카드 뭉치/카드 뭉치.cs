using System;

public class Solution {
    public string solution(string[] cards1, string[] cards2, string[] goal) {
        string answer = "Yes";
        int cards1tag = 0;
        int cards2tag = 0;
        
        for (int i = 0; i < goal.Length; i++)
        {
            if (cards1tag < cards1.Length && goal[i] == cards1[cards1tag])
            {
                cards1tag++;
                continue;
            }
            else if (cards2tag < cards2.Length && goal[i] == cards2[cards2tag])
            {
                cards2tag++;
                continue;
            }
            else 
            {
                answer = "No";
                break;
            }
        }
        
        return answer;
    }
}