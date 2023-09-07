using System;

public class Solution {
    public int[] solution(string s) {
        int[] answer = new int[s.Length];
        int x = 0;
        
        for (int i = 0; i < s.Length; i++)
        {
            x = -1;
            for (int j = i - 1; j >= 0; j--)
            {
                if(s[i] == s[j])
                {
                    x = i - j;
                    break;
                }
            }
            answer[i] = x;
        }
        return answer;
    }
}